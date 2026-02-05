using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     ServerInfo command, retrieves the server info including score, player count, map, etc.
/// </summary>
public class ServerInfo : RconCommand<ServerInfoResponse>
{
    /// <summary>
    ///     Creates a new ServerInfo command.
    /// </summary>
    public ServerInfo() : base("ServerInfo")
    {
    }
}