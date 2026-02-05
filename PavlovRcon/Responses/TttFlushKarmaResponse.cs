using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the TttFlushKarma command.
/// </summary>
public class TttFlushKarmaResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("TTTFlushKarma")]
    public bool TttFlushKarma { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return TttFlushKarma;
    }
}