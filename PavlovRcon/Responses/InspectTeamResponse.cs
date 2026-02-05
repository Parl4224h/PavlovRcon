using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the InspectTeam command.
/// </summary>
public class InspectTeamResponse : RconResponseBase
{
    /// <summary>
    ///     The players on the team that was inspected.
    /// </summary>
    [JsonPropertyName("InspectList")]
    public List<PlayerInspect> InspectList { get; set; } = [];

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Successful;
    }
}