using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// Gag command, gags or ungags a player.
/// </summary>
public class Gag : RconCommand<GagResponse>
{
    /// <summary>
    /// Creates a new Gag command.
    /// </summary>
    /// <param name="uniqueId">The unique identifier of the player to gag or ungag.</param>
    /// <param name="gag">Whether to gag or ungag the player.</param>
    public Gag(string uniqueId, bool gag) : base("Gag")
    {
        Add(uniqueId);
        Add(gag);
    }
}