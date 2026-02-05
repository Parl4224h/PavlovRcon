using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the BanList command.
/// </summary>
public class BanlistResponse : RconResponseBase
{
    /// <summary>
    ///     A list of banned player's unique ids
    /// </summary>
    [JsonPropertyName("BanList")]
    public List<string> BanList { get; set; } = [];

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Successful;
    }
}