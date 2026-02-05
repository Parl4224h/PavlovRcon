using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the PauseMatch command.
/// </summary>
public class PauseMatchResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the match was paused successfully.
    /// </summary>
    [JsonPropertyName("PauseMatch")]
    public bool PauseMatch { get; set; }

    /// <summary>
    ///     The time in seconds the match was paused for.
    /// </summary>
    [JsonPropertyName("PauseTime")]
    public int PauseTime { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return PauseMatch;
    }
}