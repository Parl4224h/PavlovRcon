using PavlovRcon.GameData;
using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// The RemoveMapRotation command, removes a map from the rotation.
/// </summary>
public class RemoveMapRotation : RconCommand<RconOkResponse>
{
    /// <summary>
    /// Creates a new RemoveMapRotation command.
    /// </summary>
    /// <param name="map">The identifier of the map to remove from the rotation either UGC###### or bundled map name</param>
    /// <param name="gameMode">The game mode for the map</param>
    public RemoveMapRotation(string map, GameMode gameMode) : base("RemoveMapRotation")
    {
        Add(map);
        Add(gameMode.ToRconId());
    }
}