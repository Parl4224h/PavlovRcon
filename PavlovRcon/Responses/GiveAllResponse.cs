using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the GiveAll command.
/// </summary>
public class GiveAllResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("GiveAll")]
    public bool GiveAll { get; set; }

    /// <summary>
    ///     The team ID that was given an item.
    /// </summary>
    [JsonPropertyName("TeamID")]
    public string TeamId { get; set; } = null!;

    /// <summary>
    ///     The item ID that was given to all players.
    /// </summary>
    [JsonPropertyName("ItemID")]
    public string ItemId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return GiveAll;
    }
}