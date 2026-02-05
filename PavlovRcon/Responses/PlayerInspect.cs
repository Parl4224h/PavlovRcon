using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

// TODO: verify fields that should be numeric actually return a string

/// <summary>
///     Data that is retrieved when inspecting a player.
/// </summary>
public class PlayerInspect
{
    /// <summary>
    ///     The name of the player.
    /// </summary>
    [JsonPropertyName("PlayerName")]
    public string PlayerName { get; set; } = null!;

    /// <summary>
    ///     The unique identifier of the player.
    /// </summary>
    [JsonPropertyName("UniqueID")]
    public string UniqueId { get; set; } = null!;

    /// <summary>
    ///     The KDA of the player.
    /// </summary>
    [JsonPropertyName("KDA")]
    public string KDA { get; set; } = null!;

    /// <summary>
    ///     The score of the player.
    /// </summary>
    [JsonPropertyName("Score")]
    public string Score { get; set; } = null!;

    /// <summary>
    ///     Whether the player is dead.
    /// </summary>
    [JsonPropertyName("Dead")]
    public bool Dead { get; set; }

    /// <summary>
    ///     The cash of the player.
    /// </summary>
    [JsonPropertyName("Cash")]
    public string Cash { get; set; } = null!;

    /// <summary>
    ///     The team ID of the player.
    /// </summary>
    [JsonPropertyName("TeamId")]
    public string TeamId { get; set; } = null!;

    /// <summary>
    ///     The ping of the player.
    /// </summary>
    [JsonPropertyName("Ping")]
    public double Ping { get; set; }

    /// <summary>
    ///     Whether the player is gagged.
    /// </summary>
    [JsonPropertyName("Gag")]
    public bool Gag { get; set; }
}