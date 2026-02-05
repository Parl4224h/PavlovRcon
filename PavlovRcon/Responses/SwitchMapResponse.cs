using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the SwitchMap command.
/// </summary>
public class SwitchMapResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the map was switched successfully.
    /// </summary>
    [JsonPropertyName("SwitchMap")]
    public bool SwitchMap { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return SwitchMap;
    }
}