using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Teleport response.
/// </summary>
public class TeleportResponse : RconResponseBase
{
    /// <summary>
    ///     The unique identifier of the player that was moved.
    /// </summary>
    [JsonPropertyName("MoveUniqueID")]
    public string MoveUniqueId { get; set; } = null!;

    /// <summary>
    ///     Whether the teleport was successful.
    /// </summary>
    [JsonPropertyName("Teleport")]
    public bool Teleport { get; set; }

    /// <summary>
    ///     The unique identifier of the player that was teleported to.
    /// </summary>
    [JsonPropertyName("ToUniqueID")]
    public string ToUniqueId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Teleport;
    }
}