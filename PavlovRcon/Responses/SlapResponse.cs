using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Slap response.
/// </summary>
public class SlapResponse : RconResponseBase
{
    /// <summary>
    ///     The unique identifier of the player that was slapped.
    /// </summary>
    [JsonPropertyName("UniqueID")]
    public string UniqueId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Successful;
    }
}