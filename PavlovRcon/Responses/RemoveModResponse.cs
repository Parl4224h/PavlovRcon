using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the RemoveMod command.
/// </summary>
public class RemoveModResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the mod was removed successfully.
    /// </summary>
    [JsonPropertyName("RemoveMod")]
    public bool RemoveMod { get; set; }

    /// <summary>
    ///     The unique identifier of the mod that was removed.
    /// </summary>
    [JsonPropertyName("UniqueID")]
    public string UniqueId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return RemoveMod;
    }
}