using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the GiveItem command.
/// </summary>
public class GiveItemResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the item was given successfully.
    /// </summary>
    [JsonPropertyName("GiveItem")]
    public bool GiveItem { get; set; }

    /// <summary>
    ///     The unique identifier of the player that was given the item.
    /// </summary>
    [JsonPropertyName("UniqueID")]
    public string UniqueId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return GiveItem;
    }
}