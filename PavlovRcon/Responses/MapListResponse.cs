using System.Text.Json.Serialization;
using PavlovRcon.GameData;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the MapList command.
/// </summary>
public class MapListResponse : RconResponseBase
{
    /// <summary>
    ///     The list of maps currently in the rotation
    /// </summary>
    [JsonPropertyName("MapList")]
    public List<Data> MapList { get; set; } = [];

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Successful;
    }

    /// <summary>
    ///     Data structure that holds the map's id and game mode.'
    /// </summary>
    public class Data
    {
        /// <summary>
        ///     The id of the map.
        /// </summary>
        [JsonPropertyName("MapId")]
        public string MapId { get; set; } = null!;

        /// <summary>
        ///     The game mode of the map.
        /// </summary>
        [JsonPropertyName("GameMode")]
        public GameMode GameMode { get; set; }
    }
}