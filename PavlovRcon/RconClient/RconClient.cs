using System.Buffers;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using PavlovRcon.Commands;
using PavlovRcon.Config;
using PavlovRcon.Exceptions;

namespace PavlovRcon.RconClient;

/// <summary>
///     Implementation of the RCON client.
/// </summary>
public class RconClient : IRconClient
{
    private readonly bool _autoConnect;
    private readonly TimeSpan _commandTimeout;
    private readonly SemaphoreSlim _connectLock = new(1, 1);

    private readonly Encoding _encoding = new UTF8Encoding(false);

    // Config variables
    private readonly string _host;
    private readonly TimeSpan _idleCheckInterval;
    private readonly TimeSpan _idleDisconnectTimeout;
    private readonly string _password;
    private readonly int _port;
    private readonly byte[] _readBuffer = ArrayPool<byte>.Shared.Rent(8192);

    private readonly SemaphoreSlim _sendLock = new(1, 1);

    private readonly StringBuilder _textBuffer = new();
    private CancellationTokenSource? _idleMonitorCts;
    private Task? _idleMonitorTask;


    // Idle Tracking
    private long _lastRequestTick;
    private NetworkStream? _stream;

    // State variables
    private TcpClient? _tcp;


    /// <summary>
    ///     Creates a new RconClient.
    /// </summary>
    /// <param name="connectionInfo">The connection info for the RCON server</param>
    /// <param name="options">The options for the RCON client</param>
    public RconClient(RconConnectionInfo connectionInfo, RconClientOptions? options = null)
    {
        _host = connectionInfo.Host;
        _port = connectionInfo.Port;
        var bytes = Encoding.UTF8.GetBytes(connectionInfo.Password);
        var hash = MD5.HashData(bytes);
        _password = Convert.ToHexString(hash).ToLowerInvariant();

        options ??= new RconClientOptions();

        _autoConnect = options.AutoConnect;
        _idleDisconnectTimeout = options.IdleDisconnectTimeout;
        _idleCheckInterval = options.IdleCheckInterval;
        _commandTimeout = options.CommandTimeout;
    }

    /// <inheritdoc />
    /// <exception cref="InvalidPasswordException">Thrown when the server rejects the password</exception>
    public async Task ConnectAsync(CancellationToken ct = default)
    {
        if (_stream is not null) return;

        await _connectLock.WaitAsync(ct).ConfigureAwait(false);
        try
        {
            if (_stream is not null) return;

            _tcp = new TcpClient();
            await _tcp.ConnectAsync(_host, _port, ct).ConfigureAwait(false);
            _stream = _tcp.GetStream();

            TouchActivity();

            await ReadUntilSubstringAsync("Password: ", ct).ConfigureAwait(false);
            await SendRawAsync(_password + "\n", ct).ConfigureAwait(false);

            var authLine = await ReadLineAsync(ct).ConfigureAwait(false);
            if (!authLine.StartsWith("Authenticated=", StringComparison.OrdinalIgnoreCase) ||
                authLine.Contains("Authenticated=0", StringComparison.OrdinalIgnoreCase))
            {
                await DisconnectCoreAsync(ct).ConfigureAwait(false); // <- use core
                throw new InvalidPasswordException("Invalid password.");
            }

            StartIdleMonitor();
        }
        finally
        {
            _connectLock.Release();
        }
    }

    /// <inheritdoc />
    public async Task DisconnectAsync(CancellationToken ct = default)
    {
        await _connectLock.WaitAsync(ct).ConfigureAwait(false);
        try
        {
            await DisconnectCoreAsync(ct).ConfigureAwait(false);
        }
        finally
        {
            _connectLock.Release();
        }
    }


    /// <inheritdoc />
    /// <exception cref="NotConnectedException">
    ///     Thrown when the client is not connected to the server and AutoConnect is
    ///     disabled
    /// </exception>
    /// <exception cref="InvalidResponseException">Thrown when the server sends a response that fails to be parsed</exception>
    /// <exception cref="TimeoutException">Thrown when the server does not respond to the command within the specified timeout</exception>
    public async Task<TResponse> SendCommandAsync<TResponse>(IRconCommand<TResponse> rconCommand,
        CancellationToken ct = default)
    {
        if (_stream is null)
        {
            if (_autoConnect)
                await ConnectAsync(ct).ConfigureAwait(false);
            else
                throw new NotConnectedException(
                    "Not connected. Call ConnectAsync() first, or set AutoConnect to true in the constructor.");
        }

        await _sendLock.WaitAsync(ct).ConfigureAwait(false);

        try
        {
            using var timeoutCts = CancellationTokenSource.CreateLinkedTokenSource(ct);
            timeoutCts.CancelAfter(_commandTimeout);

            TouchActivity();

            await SendRawAsync(rconCommand.BuildCommand() + '\n', timeoutCts.Token).ConfigureAwait(false);

            var json = await ReadJsonObjectAsync(timeoutCts.Token).ConfigureAwait(false);

            var result = JsonSerializer.Deserialize<TResponse>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            if (result is null) throw new InvalidResponseException($"Response was not valid JSON: {json}");

            TouchActivity();
            return result;
        }
        catch (OperationCanceledException) when (!ct.IsCancellationRequested)
        {
            throw new TimeoutException("Command timed out");
        }
        finally
        {
            _sendLock.Release();
        }
    }

    /// <inheritdoc />
    public async ValueTask DisposeAsync()
    {
        try
        {
            await DisconnectAsync(CancellationToken.None).ConfigureAwait(false);
        }
        catch
        {
            // ignored
        }

        ArrayPool<byte>.Shared.Return(_readBuffer);
        _sendLock.Dispose();
        _connectLock.Dispose();
    }

    private async Task DisconnectCoreAsync(CancellationToken ct)
    {
        var monitorTask = StopIdleMonitorAndGetTask();

        var acquiredSend = false;
        try
        {
            await _sendLock.WaitAsync(CancellationToken.None).ConfigureAwait(false);
            acquiredSend = true;

            if (_stream is not null)
            {
                try
                {
                    await _stream.FlushAsync(ct).ConfigureAwait(false);
                }
                catch
                {
                    // ignored
                }

                await _stream.DisposeAsync().ConfigureAwait(false);
            }

            _tcp?.Close();
            _tcp?.Dispose();
        }
        finally
        {
            _stream = null;
            _tcp = null;
            _textBuffer.Clear();

            if (acquiredSend) _sendLock.Release();

            if (monitorTask is not null)
                try
                {
                    await monitorTask.ConfigureAwait(false);
                }
                catch (OperationCanceledException)
                {
                }
                catch
                {
                    // ignored
                }
        }
    }

    private void TouchActivity()
    {
        Interlocked.Exchange(ref _lastRequestTick, Environment.TickCount64);
    }

    private void StartIdleMonitor()
    {
        if (_idleDisconnectTimeout <= TimeSpan.Zero) return;
        if (_idleMonitorTask is not null && !_idleMonitorTask.IsCompleted) return;

        _idleMonitorCts = new CancellationTokenSource();
        var token = _idleMonitorCts.Token;

        _idleMonitorTask = Task.Run(async () =>
        {
            var interval = _idleCheckInterval <= TimeSpan.Zero ? TimeSpan.FromSeconds(5) : _idleCheckInterval;
            using var timer = new PeriodicTimer(interval);

            try
            {
                while (await timer.WaitForNextTickAsync(token).ConfigureAwait(false))
                {
                    if (_stream is null) continue;

                    var last = Interlocked.Read(ref _lastRequestTick);
                    var elapsed = Environment.TickCount64 - last;
                    if (elapsed < 0) elapsed = long.MaxValue;

                    if (elapsed >= (long)_idleDisconnectTimeout.TotalMilliseconds)
                    {
                        if (!await _sendLock.WaitAsync(0, token)) continue;

                        try
                        {
                            last = Interlocked.Read(ref _lastRequestTick);
                            elapsed = Environment.TickCount64 - last;
                            if (elapsed < 0) elapsed = long.MaxValue;

                            if (_stream is not null && elapsed >= (long)_idleDisconnectTimeout.TotalMilliseconds)
                            {
                                await DisconnectAsync(CancellationToken.None).ConfigureAwait(false);
                                return;
                            }
                        }
                        finally
                        {
                            if (_sendLock.CurrentCount == 0) _sendLock.Release();
                        }
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // expected on shutdown
            }
            catch
            {
                // optional: log
            }
        }, CancellationToken.None);
    }

    private Task? StopIdleMonitorAndGetTask()
    {
        var cts = _idleMonitorCts;
        if (cts is null)
            return null;

        var task = _idleMonitorTask;

        try
        {
            cts.Cancel();
        }
        catch
        {
            /* ignore */
        }

        _idleMonitorCts = null;
        _idleMonitorTask = null;

        try
        {
            cts.Dispose();
        }
        catch
        {
            /* ignore */
        }

        return task;
    }

    private async Task<string> ReadLineAsync(CancellationToken ct)
    {
        while (true)
        {
            ct.ThrowIfCancellationRequested();

            var existing = _textBuffer.ToString();
            var index = existing.IndexOf('\n');

            if (index >= 0)
            {
                var line = existing.Substring(0, index);
                _textBuffer.Remove(0, index + 1);
                return line.TrimEnd('\r', '\n');
            }

            await ReadMoreTextAsync(ct).ConfigureAwait(false);
        }
    }

    private async Task<string> ReadJsonObjectAsync(CancellationToken ct)
    {
        // Reads bytes until a complete top-level JSON object is collected, using brace balancing.
        var sb = new StringBuilder();
        var started = false;
        var inString = false;
        var escape = false;
        var depth = 0;

        while (true)
        {
            // If we already have buffered text from earlier reads, consume it first.
            if (_textBuffer.Length > 0)
            {
                var chunk = _textBuffer.ToString();
                _textBuffer.Clear();
                ConsumeChunk(chunk);
            }

            if (started && depth == 0)
            {
                var json = sb.ToString().Trim();
                // Optional: strip any trailing \r\n after JSON if it got included
                return json.TrimEnd('\r', '\n');
            }

            // Need more data
            var n = await _stream!.ReadAsync(_readBuffer, 0, _readBuffer.Length, ct).ConfigureAwait(false);
            if (n <= 0) throw new IOException("Disconnected.");
            var text = _encoding.GetString(_readBuffer, 0, n);
            ConsumeChunk(text);
        }

        void ConsumeChunk(string text)
        {
            foreach (var c in text)
            {
                if (!started)
                {
                    // Skip anything until the first '{' (in case the server echoes or prints a prefix)
                    if (c == '{')
                    {
                        started = true;
                        depth = 1;
                        sb.Append(c);
                    }

                    continue;
                }

                sb.Append(c);

                if (escape)
                {
                    escape = false;
                    continue;
                }

                if (inString)
                {
                    if (c == '\\') escape = true;
                    else if (c == '"') inString = false;
                    continue;
                }

                if (c == '"')
                {
                    inString = true;
                    continue;
                }

                if (c == '{') depth++;
                else if (c == '}') depth--;
            }
        }
    }

    private async Task ReadUntilSubstringAsync(string substring, CancellationToken ct)
    {
        while (true)
        {
            ct.ThrowIfCancellationRequested();

            if (_textBuffer.ToString().Contains(substring, StringComparison.Ordinal))
                return;

            // Read more data into _textBuffer; expected to observe ct (either via await or throwing)
            await ReadMoreTextAsync(ct).ConfigureAwait(false);
        }
    }

    private async Task ReadMoreTextAsync(CancellationToken ct)
    {
        var n = await _stream!.ReadAsync(_readBuffer, 0, _readBuffer.Length, ct).ConfigureAwait(false);
        if (n <= 0) throw new IOException("Connection closed");
        _textBuffer.Append(_encoding.GetString(_readBuffer, 0, n));
    }

    private async Task SendRawAsync(string text, CancellationToken ct)
    {
        var bytes = _encoding.GetBytes(text);
        await _stream!.WriteAsync(bytes, 0, bytes.Length, ct).ConfigureAwait(false);
        await _stream.FlushAsync(ct).ConfigureAwait(false);
    }
}