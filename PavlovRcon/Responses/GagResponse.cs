using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Gag response.
/// </summary>
public class GagResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the command was successful.
    /// </summary>
    [JsonPropertyName("Gag")]
    public bool Gag { get; set; }

    /// <summary>
    ///     The unique identifier of the player that was gagged or ungagged.
    /// </summary>
    [JsonPropertyName("UniqueID")]
    public string UniqueId { get; set; } = null!;

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Gag;
    }
}