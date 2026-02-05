using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// UpdateServerName command, updates the server name.
/// </summary>
public class UpdateServerName : RconCommand<UpdateServerNameResponse>
{
    /// <summary>
    /// Creates a new UpdateServerName command.
    /// </summary>
    /// <param name="serverName">The new server name to set.</param>
    public UpdateServerName(string serverName) : base("UpdateServerName") => Add(serverName);
}