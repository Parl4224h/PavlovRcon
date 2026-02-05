using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the TttSetRole command.
/// </summary>
public class TttSetRoleResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("TTTSetRole")]
    public bool TttSetRole { get; set; }

    /// <summary>
    ///     The unique identifier of the player.
    /// </summary>
    [JsonPropertyName("UniqueID")]
    public string UniqueId { get; set; } = null!;

    /// <summary>
    ///     The role that was set.
    /// </summary>
    [JsonPropertyName("Role")]
    public string Role { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return TttSetRole;
    }
}