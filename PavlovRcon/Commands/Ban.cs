namespace PavlovRcon.Commands;

/// <summary>
/// Bans a player.
/// </summary>
public class Ban : RconCommand<string>
{
    /// <summary>
    /// Creates a new Ban command.
    /// </summary>
    /// <param name="uniqueId">The unique identifier of the player to ban.</param>
    public Ban(string uniqueId) : base("Ban") => Add(uniqueId);
}