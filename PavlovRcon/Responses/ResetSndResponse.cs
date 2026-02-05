using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the ResetSnd command.
/// </summary>
public class ResetSndResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("ResetSND")]
    public bool ResetSnd { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return ResetSnd;
    }
}