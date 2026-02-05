using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the GiveTeamCash command.
/// </summary>
public class GiveTeamCashResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("GiveTeamCash")]
    public bool GiveTeamCash { get; set; }

    /// <summary>
    ///     The team ID that was given cash.
    /// </summary>
    [JsonPropertyName("TeamID")]
    public string TeamId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return GiveTeamCash;
    }
}