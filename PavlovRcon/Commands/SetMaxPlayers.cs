using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// SetMaxPlayers command, sets the max players.
/// </summary>
public class SetMaxPlayers : RconCommand<SetMaxPlayersResponse>
{
    /// <summary>
    /// Creates a new SetMaxPlayers command.
    /// </summary>
    /// <param name="maxPlayers">The maximum number of players to set.</param>
    public SetMaxPlayers(int maxPlayers) : base("SetMaxPlayers") => Add(maxPlayers);
}