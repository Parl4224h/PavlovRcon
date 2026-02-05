using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the UgcModList command.
/// </summary>
public class UgcModListResponse : RconResponseBase
{
    /// <summary>
    ///     List of mod identifiers currently added to the server.
    /// </summary>
    [JsonPropertyName("ModList")]
    public List<string> ModList { get; set; } = [];

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Successful;
    }
}