using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the TttPauseTimer command.
/// </summary>
public class TttPauseTimerResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the pause timer was successfully toggled.
    /// </summary>
    [JsonPropertyName("TTTPauseTimer")]
    public bool TttPauseTimer { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return TttPauseTimer;
    }
}