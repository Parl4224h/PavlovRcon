using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the UpdateServerName command.
/// </summary>
public class UpdateServerNameResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the server name was updated successfully.
    /// </summary>
    [JsonPropertyName("UpdateServerName")]
    public bool UpdateServerName { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return UpdateServerName;
    }
}