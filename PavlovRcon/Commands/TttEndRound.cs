using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// TttEndRound command, ends the current round.
/// </summary>
public class TttEndRound : RconCommand<RconOkResponse>
{
    /// <summary>
    /// Creates a new TttEndRound command.
    /// </summary>
    /// <param name="teamId">The unique identifier of the team to win the round.</param>
    public TttEndRound(string teamId) : base("TTTEndRound") => Add(teamId);
}