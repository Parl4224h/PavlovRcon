namespace PavlovRcon.Commands;

/// <summary>
/// Kick command, kicks a player from the server.
/// </summary>
public class Kick : RconCommand<string>
{
    /// <summary>
    /// Creates a new Kick command.
    /// </summary>
    /// <param name="uniqueId">The unique id to kick.</param>
    public Kick(string uniqueId) : base("Kick") => Add(uniqueId);
}