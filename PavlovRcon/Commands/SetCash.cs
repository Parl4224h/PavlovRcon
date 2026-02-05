using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// SetCash command, sets the cash of a player.
/// </summary>
public class SetCash : RconCommand<SetCashResponse>
{
    /// <summary>
    /// Creates a new SetCash command.
    /// </summary>
    /// <param name="uniqueId">The unique ID of the player to set cash of.</param>
    /// <param name="amount">The amount of cash to set the player to.</param>
    public SetCash(string uniqueId, int amount) : base("SetCash")
    {
        Add(uniqueId);
        Add(amount);
    }
}