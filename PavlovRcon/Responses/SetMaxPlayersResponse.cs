using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the SetMaxPlayers command.
/// </summary>
public class SetMaxPlayersResponse : RconResponseBase
{
    /// <summary>
    ///     The new max players value.
    /// </summary>
    [JsonPropertyName("MaxPlayers")]
    public int MaxPlayers { get; set; }

    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("SetMaxPlayers")]
    public bool SetMaxPlayers { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return SetMaxPlayers;
    }
}