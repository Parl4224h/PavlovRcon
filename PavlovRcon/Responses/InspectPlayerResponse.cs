using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the InspectPlayer command.
/// </summary>
public class InspectPlayerResponse : RconResponseBase
{
    /// <summary>
    ///     The player that was inspected.
    /// </summary>
    [JsonPropertyName("PlayerInfo")]
    public PlayerInspect PlayerInfo { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Successful;
    }
}