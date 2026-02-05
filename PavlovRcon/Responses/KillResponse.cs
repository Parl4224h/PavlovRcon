using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the Kill command.
/// </summary>
public class KillResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the kill was successful.
    /// </summary>
    [JsonPropertyName("Kill")]
    public bool Kill { get; set; }

    /// <summary>
    ///     The unique identifier of the player that was killed.
    /// </summary>
    [JsonPropertyName("UniqueId")]
    public string UniqueId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Kill;
    }
}