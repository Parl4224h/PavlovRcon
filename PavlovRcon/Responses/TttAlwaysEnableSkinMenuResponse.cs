using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the TttAlwaysEnableSkinMenu command.
/// </summary>
public class TttAlwaysEnableSkinMenuResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("TTTAlwaysEnableSkinMenu")]
    public bool TttAlwaysEnableSkinMenu { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return TttAlwaysEnableSkinMenu;
    }
}