using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the RefreshList command.
/// </summary>
public class RefreshListResponse : RconResponseBase
{
    /// <summary>
    ///     The list of players that are currently connected to the server.
    /// </summary>
    [JsonPropertyName("PlayerList")]
    public List<Data> PlayerList { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Successful;
    }

    /// <summary>
    ///     Data structure that holds the player's username and unique id.'
    /// </summary>
    public class Data
    {
        /// <summary>
        ///     The unique identifier of the player.
        /// </summary>
        [JsonPropertyName("UniqueID")] public string UniqueId = null!;

        /// <summary>
        ///     The username of the player.
        /// </summary>
        [JsonPropertyName("Username")] public string Username = null!;
    }
}