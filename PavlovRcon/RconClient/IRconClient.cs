using PavlovRcon.Commands;

namespace PavlovRcon.RconClient;

/// <summary>
///     Contract for the RCON client.
/// </summary>
public interface IRconClient : IAsyncDisposable
{
    /// <summary>
    ///     Connects to the RCON server.
    /// </summary>
    /// <param name="ct">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public Task ConnectAsync(CancellationToken ct = default);

    /// <summary>
    ///     Disconnects from the RCON server.
    ///     <param name="ct">
    ///         A cancellation token that can be used by other objects or threads to receive notice of
    ///         cancellation.
    ///     </param>
    /// </summary>
    public Task DisconnectAsync(CancellationToken ct = default);

    /// <summary>
    ///     Sends a command over RCON to the server.
    /// </summary>
    /// <param name="rconCommand">The command to send</param>
    /// <param name="ct">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <typeparam name="TResponse">The response for the command</typeparam>
    /// <returns></returns>
    public Task<TResponse> SendCommandAsync<TResponse>(IRconCommand<TResponse> rconCommand,
        CancellationToken ct = default);
}