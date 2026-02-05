using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the SetPlayerSkin command.
/// </summary>
public class SetPlayerSkinResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the skin was set successfully.
    /// </summary>
    [JsonPropertyName("SetPlayerSkin")]
    public bool SetPlayerSkin { get; set; }

    /// <summary>
    ///     The unique identifier of the player.
    /// </summary>
    [JsonPropertyName("UniqueID")]
    public string UniqueId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return SetPlayerSkin;
    }
}