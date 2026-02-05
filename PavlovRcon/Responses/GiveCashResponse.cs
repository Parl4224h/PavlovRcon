using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the GiveCash command.
/// </summary>
public class GiveCashResponse : RconResponseBase
{
    /// <summary>
    ///     The unique identifier of the player.
    /// </summary>
    [JsonPropertyName("UniqueID")] public string UniqueId = null!;

    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("GiveCash")]
    public bool GiveCash { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return GiveCash;
    }
}