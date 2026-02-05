using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the TttSetKarma command.
/// </summary>
public class TttSetKarmaResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("TTTSetKarma")]
    public bool TttSetKarma { get; set; }

    /// <summary>
    ///     The unique identifier of the player.
    /// </summary>
    [JsonPropertyName("UniqueID")]
    public string UniqueId { get; set; } = null!;

    /// <summary>
    ///     The new karma value of the player.
    /// </summary>
    [JsonPropertyName("Karma")]
    public int Karma { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return TttSetKarma;
    }
}