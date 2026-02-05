using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the TttGiveCredits command.
/// </summary>
public class TttGiveCreditsResponse : RconResponseBase
{
    /// <summary>
    ///     The player's new credit amount.
    /// </summary>
    [JsonPropertyName("CreditAmount")]
    public int CreditAmount { get; set; }

    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("TTTGiveCredits")]
    public bool TttGiveCredits { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return TttGiveCredits;
    }
}