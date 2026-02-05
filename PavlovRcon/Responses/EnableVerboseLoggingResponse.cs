using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the EnableVerboseLogging command.
/// </summary>
public class EnableVerboseLoggingResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("EnableVerboseLogging")]
    public bool EnableVerboseLogging { get; set; }

    /// <summary>
    ///     The current state of verbose logging after the command was executed.
    /// </summary>
    [JsonPropertyName("VerboseLoggingState")]
    public bool VerboseLoggingState { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return EnableVerboseLogging;
    }
}