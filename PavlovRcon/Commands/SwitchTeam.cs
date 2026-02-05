namespace PavlovRcon.Commands;

/// <summary>
/// SwitchTeam command, switches a player's team.
/// </summary>
public class SwitchTeam : RconCommand<string>
{
    /// <summary>
    /// Creates a new SwitchTeam command.
    /// </summary>
    /// <param name="uniqueId">The unique identifier of the player to switch teams.</param>
    /// <param name="targetTeamId">The unique identifier of the target team.</param>
    public SwitchTeam(string uniqueId, string targetTeamId) : base("SwitchTeam")
    {
        Add(uniqueId);
        Add(targetTeamId);
    }
}