using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     GiveCash command, gives cash to a player.
/// </summary>
public class GiveCash : RconCommand<GiveCashResponse>
{
    /// <summary>
    ///     Creates a new GiveCash command.
    /// </summary>
    /// <param name="uniqueId">The unique ID of the player to give cash to.</param>
    /// <param name="amount">The amount of cash to give.</param>
    public GiveCash(string uniqueId, int amount) : base("GiveCash")
    {
        Add(uniqueId);
        Add(amount);
    }
}