using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the Kick command.
/// </summary>
public class KickResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the kick was successful.
    /// </summary>
    [JsonPropertyName("Kick")]
    public bool Kick { get; set; }

    /// <summary>
    ///     The unique identifier of the player that was kicked.
    /// </summary>
    [JsonPropertyName("UniqueId")]
    public string UniqueId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Kick;
    }
}