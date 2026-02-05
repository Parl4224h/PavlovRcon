using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the Ban command.
/// </summary>
public class BanResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the ban was successful.
    /// </summary>
    [JsonPropertyName("Ban")]
    public bool Ban { get; set; }

    /// <summary>
    ///     The unique identifier of the player.
    /// </summary>
    [JsonPropertyName("UniqueID")]
    public string UniqueId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Ban;
    }
}