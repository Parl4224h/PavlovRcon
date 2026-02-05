namespace PavlovRcon.Commands;

/// <summary>
/// SetPlayerSkin command, sets the skin of a player.
/// </summary>
public class SetPlayerSkin : RconCommand<string>
{
    /// <summary>
    /// Create a new SetPlayerSkin command.
    /// </summary>
    /// <param name="uniqueId">The unique identifier of the player.</param>
    /// <param name="skinId">The ID of the skin to set.</param>
    public SetPlayerSkin(string uniqueId, int skinId) : base("SetPlayerSkin")
    {
        Add(uniqueId);
        Add(skinId);
    }
}