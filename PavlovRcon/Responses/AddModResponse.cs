using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the AddMod command.
/// </summary>
public class AddModResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the mod was added successfully.
    /// </summary>
    [JsonPropertyName("AddMod")]
    public bool AddMod { get; set; }

    /// <summary>
    ///     The unique identifier of the mod.
    /// </summary>
    [JsonPropertyName("UniqueID")]
    public string UniqueId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return AddMod;
    }
}