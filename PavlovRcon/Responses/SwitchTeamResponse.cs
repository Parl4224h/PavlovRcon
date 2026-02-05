using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the SwitchTeam command.
/// </summary>
public class SwitchTeamResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the team was switched successfully.
    /// </summary>
    [JsonPropertyName("SwitchTeam")]
    public bool SwitchTeam { get; set; }

    /// <summary>
    ///     The unique identifier of the player.
    /// </summary>
    [JsonPropertyName("UniqueID")]
    public string UniqueId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return SwitchTeam;
    }
}