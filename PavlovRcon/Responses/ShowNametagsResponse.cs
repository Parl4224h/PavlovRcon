using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the ShowNametags command.
/// </summary>
public class ShowNametagsResponse : RconResponseBase
{
    /// <summary>
    ///     Whether nametags are enabled after the command was executed.
    /// </summary>
    [JsonPropertyName("NametagsEnabled")]
    public bool NametagsEnabled { get; set; }

    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("ShowNametags")]
    public bool ShowNametags { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return ShowNametags;
    }
}