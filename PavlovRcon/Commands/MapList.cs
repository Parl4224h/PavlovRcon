using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     MapList command, retrieves the list of maps and game modes currently in rotation.
/// </summary>
public class MapList : RconCommand<MapListResponse>
{
    /// <summary>
    ///     Creates a new MapList command.
    /// </summary>
    public MapList() : base("MapList")
    {
    }
}