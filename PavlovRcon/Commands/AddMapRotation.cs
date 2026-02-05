using PavlovRcon.GameData;
using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     The AddMapRotation command.
/// </summary>
/// <remarks>
///     Adds a map to the map rotation with a specified game mode.
/// </remarks>
public class AddMapRotation : RconCommand<RconOkResponse>
{
    /// <summary>
    ///     Creates a new AddMapRotation command.
    /// </summary>
    /// <param name="map">The identifier of the map to add to the rotation either UGC###### or bundled map name</param>
    /// <param name="gameMode">The game mode for the map</param>
    public AddMapRotation(string map, GameMode gameMode) : base("AddMapRotation")
    {
        Add(map);
        Add(gameMode.ToRconId());
    }
}