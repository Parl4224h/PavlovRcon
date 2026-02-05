using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the EnableWhitelist command.
/// </summary>
public class EnableWhitelistResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("EnableWhitelist")]
    public bool EnableWhitelist { get; set; }

    /// <summary>
    ///     The current state of the whitelist after the command was executed.
    /// </summary>
    [JsonPropertyName("WhitelistState")]
    public bool WhitelistState { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return EnableWhitelist;
    }
}