using PavlovRcon.GameData;

namespace PavlovRcon.Commands;

/// <summary>
/// SwitchMap command, switches to a specified map.
/// </summary>
public class SwitchMap : RconCommand<string>
{
    /// <summary>
    /// Creates a new SwitchMap command.
    /// </summary>
    /// <param name="map">The name of the map to switch to.</param>
    /// <param name="gameMode">The game mode to start the map with.</param>
    public SwitchMap(string map, GameMode gameMode) : base("SwitchMap")
    {
        Add(map);
        Add(gameMode.ToRconId());
    }
}