using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the ModeratorList command.
/// </summary>
public class ModeratorListResponse : RconResponseBase
{
    /// <summary>
    ///     The list of moderator unique identifiers.
    /// </summary>
    [JsonPropertyName("ModeratorList")]
    public List<string> ModeratorList { get; set; } = [];

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Successful;
    }
}