using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the EnableCompMode command.
/// </summary>
public class EnableCompModeResponse : RconResponseBase
{
    /// <summary>
    ///     The current state of competitive mode after the command was executed.
    /// </summary>
    [JsonPropertyName("CompModeState")]
    public bool CompModeState { get; set; }

    /// <summary>
    ///     Whether the command was successful.
    /// </summary>
    [JsonPropertyName("EnableCompMode")]
    public bool EnableCompMode { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return EnableCompMode;
    }
}