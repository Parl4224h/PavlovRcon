using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// InspectTeam command, inspects a team.
/// </summary>
public class InspectTeam : RconCommand<InspectTeamResponse>
{
    /// <summary>
    /// Creates a new InspectTeam command.
    /// </summary>
    /// <param name="teamId">The team ID to inspect.</param>
    public InspectTeam(string teamId) : base("InspectTeam") => Add(teamId);
}