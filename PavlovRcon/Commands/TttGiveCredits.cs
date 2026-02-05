using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// TttGiveCredits command, gives a player credits.
/// </summary>
public class TttGiveCredits : RconCommand<TttGiveCreditsResponse>
{
    /// <summary>
    /// Creates a new TttGiveCredits command.
    /// </summary>
    /// <param name="uniqueId">The unique identifier of the player to give credits to.</param>
    /// <param name="amount">The amount of credits to give.</param>
    public TttGiveCredits(string uniqueId, int amount) : base("TTTGiveCredits")
    {
        Add(uniqueId);
        Add(amount);
    }
}