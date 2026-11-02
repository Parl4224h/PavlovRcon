using System.Net;
using System.Net.Sockets;
using System.Text;
using PavlovRcon.Commands;
using PavlovRcon.Config;
using Xunit;

namespace PavlovRcon.Tests;

public sealed class ConnectionRecoveryTests
{
    [Theory]
    [InlineData("disconnect")]
    [InlineData("timeout")]
    [InlineData("cancel")]
    public async Task Next_command_reconnects_after_a_failed_command_without_replaying_it(string failure)
    {
        using var deadline = new CancellationTokenSource(TimeSpan.FromSeconds(15));
        using var listener = new TcpListener(IPAddress.Loopback, 0);
        listener.Start();
        var port = ((IPEndPoint)listener.LocalEndpoint).Port;
        var firstCommand = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
        var commands = new List<string>();
        var server = Task.Run(async () =>
        {
            using (var first = await listener.AcceptTcpClientAsync(deadline.Token))
            {
                var reader = await AuthenticateAsync(first, deadline.Token);
                commands.Add((await reader.ReadLineAsync(deadline.Token))!);
                firstCommand.SetResult();
                if (failure != "disconnect")
                {
                    // An incomplete JSON response must be discarded before reconnecting.
                    await first.GetStream().WriteAsync(Encoding.UTF8.GetBytes("{\"Value\":"), deadline.Token);
                    Assert.Null(await reader.ReadLineAsync(deadline.Token));
                }
            }
            using var second = await listener.AcceptTcpClientAsync(deadline.Token);
            var secondReader = await AuthenticateAsync(second, deadline.Token);
            commands.Add((await secondReader.ReadLineAsync(deadline.Token))!);
            await second.GetStream().WriteAsync(Encoding.UTF8.GetBytes("{\"Value\":2}"), deadline.Token);
        }, deadline.Token);
        await using var client = new RconClient.RconClient(new RconConnectionInfo("127.0.0.1", port, "secret"),
            new RconClientOptions { CommandTimeout = TimeSpan.FromSeconds(2), IdleDisconnectTimeout = TimeSpan.Zero });
        using var cancelled = CancellationTokenSource.CreateLinkedTokenSource(deadline.Token);
        var command = client.SendCommandAsync(new Probe("first"), cancelled.Token);
        await firstCommand.Task.WaitAsync(deadline.Token);
        if (failure == "cancel") cancelled.Cancel();
        if (failure == "disconnect") await Assert.ThrowsAsync<IOException>(() => command);
        else if (failure == "timeout") await Assert.ThrowsAsync<TimeoutException>(() => command);
        else await Assert.ThrowsAnyAsync<OperationCanceledException>(() => command);

        var result = await client.SendCommandAsync(new Probe("second"), deadline.Token);
        Assert.Equal(2, result.Value);
        await server.WaitAsync(deadline.Token);
        Assert.Equal(new[] { "first", "second" }, commands);
    }

    [Fact]
    public async Task Failed_authentication_transport_is_discarded_before_connecting_again()
    {
        using var deadline = new CancellationTokenSource(TimeSpan.FromSeconds(15));
        using var listener = new TcpListener(IPAddress.Loopback, 0);
        listener.Start();
        var port = ((IPEndPoint)listener.LocalEndpoint).Port;
        var server = Task.Run(async () =>
        {
            using (var first = await listener.AcceptTcpClientAsync(deadline.Token)) { }
            using var second = await listener.AcceptTcpClientAsync(deadline.Token);
            var reader = await AuthenticateAsync(second, deadline.Token);
            Assert.Equal("second", await reader.ReadLineAsync(deadline.Token));
            await second.GetStream().WriteAsync(Encoding.UTF8.GetBytes("{\"Value\":2}"), deadline.Token);
        }, deadline.Token);
        await using var client = new RconClient.RconClient(new RconConnectionInfo("127.0.0.1", port, "secret"),
            new RconClientOptions { CommandTimeout = TimeSpan.FromSeconds(2), IdleDisconnectTimeout = TimeSpan.Zero });
        await Assert.ThrowsAsync<IOException>(() => client.ConnectAsync(deadline.Token));
        Assert.Equal(2, (await client.SendCommandAsync(new Probe("second"), deadline.Token)).Value);
        await server.WaitAsync(deadline.Token);
    }

    private static async Task<StreamReader> AuthenticateAsync(TcpClient peer, CancellationToken ct)
    {
        var stream = peer.GetStream();
        await stream.WriteAsync(Encoding.UTF8.GetBytes("Password: "), ct);
        var reader = new StreamReader(stream, Encoding.UTF8, leaveOpen: true);
        Assert.NotEmpty((await reader.ReadLineAsync(ct))!);
        await stream.WriteAsync(Encoding.UTF8.GetBytes("Authenticated=1\n"), ct);
        return reader;
    }

    public sealed class Reply { public int Value { get; set; } }
    private sealed class Probe(string name) : IRconCommand<Reply>
    {
        public string BuildCommand() => name;
    }
}
