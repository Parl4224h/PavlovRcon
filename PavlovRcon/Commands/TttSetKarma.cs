using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     TTTSetKarma command, sets the karma of a player.
/// </summary>
public class TttSetKarma : RconCommand<TttSetKarmaResponse>
{
    /// <summary>
    ///     Sets the karma of a player.
    /// </summary>
    /// <param name="uniqueId">The unique identifier of the player.</param>
    /// <param name="amount">The amount of karma to set.</param>
    public TttSetKarma(string uniqueId, int amount) : base("TTTSetKarma")
    {
        Add(uniqueId);
        Add(amount);
    }
}