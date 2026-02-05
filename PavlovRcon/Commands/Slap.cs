using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// Slap command, deals damage to a player.
/// </summary>
public class Slap : RconCommand<SlapResponse>
{
    /// <summary>
    /// Create a new Slap command.
    /// </summary>
    /// <param name="uniqueId">The unique identifier of the player to slap.</param>
    /// <param name="amount">The amount of damage to deal. Negative numbers will cause the player to be healed with large enough, making players seemingly invincible</param>
    public Slap(string uniqueId, int amount) : base("Slap")
    {
        Add(uniqueId);
        Add(amount);
    }
}