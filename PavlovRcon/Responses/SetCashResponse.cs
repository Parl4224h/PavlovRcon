using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the SetCash command.
/// </summary>
public class SetCashResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("SetCash")]
    public bool SetCash { get; set; }

    /// <summary>
    ///     The unique identifier of the player.
    /// </summary>
    [JsonPropertyName("UniqueID")]
    public string UniqueId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return SetCash;
    }
}