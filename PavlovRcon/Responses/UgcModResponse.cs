using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the UgcAddMod and UgcRemoveMod commands.
/// </summary>
public class UgcModResponse : RconResponseBase
{
    /// <summary>
    ///     The unique identifier of the mod that was added or removed.
    /// </summary>
    [JsonPropertyName("ModId")]
    public string ModId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Successful;
    }
}