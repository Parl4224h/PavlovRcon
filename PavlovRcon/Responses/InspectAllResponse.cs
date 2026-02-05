using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the InspectAll command.
/// </summary>
public class InspectAllResponse : RconResponseBase
{
    /// <summary>
    ///     All players that were inspected.
    /// </summary>
    [JsonPropertyName("InspectList")]
    public List<PlayerInspect> InspectList { get; set; } = [];

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Successful;
    }
}