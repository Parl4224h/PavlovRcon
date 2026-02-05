using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the Ban command.
/// </summary>
public class UnbanResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the unban was successful.
    /// </summary>
    [JsonPropertyName("Unban")]
    public bool Unban { get; set; }

    /// <summary>
    ///     The unique identifier of the player.
    /// </summary>
    [JsonPropertyName("UniqueID")]
    public string UniqueId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Unban;
    }
}