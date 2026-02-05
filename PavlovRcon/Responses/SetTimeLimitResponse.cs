using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the SetTimeLimit command.
/// </summary>
public class SetTimeLimitResponse : RconResponseBase
{
    /// <summary>
    ///     The new time limit in seconds.
    /// </summary>
    [JsonPropertyName("TimeLimit")]
    public int TimeLimit { get; set; }

    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("SetTimeLimit")]
    public bool SetTimeLimit { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return SetTimeLimit;
    }
}