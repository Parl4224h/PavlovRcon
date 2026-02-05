using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// Teleport command, teleports a player to another player.
/// </summary>
public class Teleport : RconCommand<TeleportResponse>
{
    /// <summary>
    /// Creates a new Teleport command.
    /// </summary>
    /// <param name="sourceUniqueId">The unique identifier of the player to teleport.</param>
    /// <param name="targetUniqueId">The unique identifier of the player to teleport to.</param>
    public Teleport(string sourceUniqueId, string targetUniqueId) : base("Teleport")
    {
        Add(sourceUniqueId);
        Add(targetUniqueId);
    }
}