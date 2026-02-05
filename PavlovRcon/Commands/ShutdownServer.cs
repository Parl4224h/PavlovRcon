namespace PavlovRcon.Commands;

/// <summary>
/// ShutdownServer command, shuts down the server.
/// </summary>
public class ShutdownServer : RconCommand<string>
{
    /// <summary>
    /// Creates a new ShutdownServer command.
    /// </summary>
    public ShutdownServer() : base("ShutdownServer") { }
}