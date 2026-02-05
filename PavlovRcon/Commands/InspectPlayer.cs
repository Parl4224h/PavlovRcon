namespace PavlovRcon.Commands;

/// <summary>
/// InspectPlayer command, inspects a player.
/// </summary>
public class InspectPlayer : RconCommand<string>
{
    /// <summary>
    /// Creates a new InspectPlayer command.
    /// </summary>
    /// <param name="uniqueId">The unique id to inspect.</param>
    public InspectPlayer(string uniqueId) : base("InspectPlayer") => Add(uniqueId);
}