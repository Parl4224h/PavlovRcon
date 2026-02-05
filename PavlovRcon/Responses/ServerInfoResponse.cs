using System.Text.Json.Serialization;
using PavlovRcon.GameData;

namespace PavlovRcon.Responses;

/// <summary>
///     ServerInfo response.
/// </summary>
public class ServerInfoResponse : RconResponseBase
{
    /// <summary>
    ///     The server info.
    /// </summary>
    [JsonPropertyName("ServerInfo")]
    public Data ServerInfo { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Successful;
    }

    /// <summary>
    ///     Data structure that holds the server info.
    /// </summary>
    public class Data
    {
        /// <summary>
        ///     The map label.
        /// </summary>
        [JsonPropertyName("MapLabel")]
        public string MapLabel { get; set; } = null!;

        /// <summary>
        ///     The game mode.
        /// </summary>
        [JsonPropertyName("GameMode")]
        public GameMode GameMode { get; set; }

        /// <summary>
        ///     The server name.
        /// </summary>
        [JsonPropertyName("ServerName")]
        public string ServerName { get; set; } = null!;

        /// <summary>
        ///     Whether teams are enabled.
        /// </summary>
        [JsonPropertyName("Teams")]
        public bool Teams { get; set; }

        /// <summary>
        ///     Team 0's score.
        /// </summary>
        [JsonPropertyName("Team0Score")]
        public string Team0Score { get; set; } = null!;

        /// <summary>
        ///     Team 1's score.
        /// </summary>
        [JsonPropertyName("Team1Score")]
        public string Team1Score { get; set; } = null!;

        /// <summary>
        ///     The current round number.
        /// </summary>
        [JsonPropertyName("Round")]
        public string Round { get; set; } = null!;

        /// <summary>
        ///     The current round state.
        /// </summary>
        [JsonPropertyName("RoundState")]
        public string RoundState { get; set; } = null!;

        /// <summary>
        ///     The current player count.
        /// </summary>
        [JsonPropertyName("PlayerCount")]
        public string PlayerCount { get; set; } = null!;
    }
}