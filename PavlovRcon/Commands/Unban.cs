namespace PavlovRcon.Commands;

/// <summary>
/// Unban command, unbans a player.
/// </summary>
public class Unban : RconCommand<string>
{
    /// <summary>
    /// Creates a new Unban command.
    /// </summary>
    /// <param name="uniqueId">The unique identifier of the player to unban.</param>
    public Unban(string uniqueId) : base("Unban") => Add(uniqueId);
}