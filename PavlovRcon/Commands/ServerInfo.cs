namespace PavlovRcon.Commands;

/// <summary>
/// ServerInfo command, retrieves the server info including score, player count, map, etc.
/// </summary>
public class ServerInfo : RconCommand<string>
{
    /// <summary>
    /// Creates a new ServerInfo command.
    /// </summary>
    public ServerInfo() : base("ServerInfo") { }
}