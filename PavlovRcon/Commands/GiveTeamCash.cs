namespace PavlovRcon.Commands;

/// <summary>
/// GiveTeamCash command, gives cash to a team.
/// </summary>
public class GiveTeamCash : RconCommand<string>
{
    /// <summary>
    /// Creates a new GiveTeamCash command.
    /// </summary>
    /// <param name="teamId">The team ID to give cash to.</param>
    /// <param name="amount">The amount of cash to give.</param>
    public GiveTeamCash(string teamId, int amount) : base("GiveTeamCash")
    {
        Add(teamId);
        Add(amount);
    }
}