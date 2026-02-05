using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// ShutdownServer command, shuts down the server.
/// </summary>
public class ShutdownServer : RconCommand<RconOkResponse>
{
    /// <summary>
    /// Creates a new ShutdownServer command.
    /// </summary>
    public ShutdownServer() : base("ShutdownServer") { }
}