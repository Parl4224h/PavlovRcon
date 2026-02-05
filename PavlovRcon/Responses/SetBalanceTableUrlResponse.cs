using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the SetBalanceTableUrl command.
/// </summary>
public class SetBalanceTableUrlResponse : RconResponseBase
{
    /// <summary>
    ///     The Github URL that was set.
    /// </summary>
    [JsonPropertyName("GithubURL")]
    public string GithubUrl { get; set; } = null!;

    /// <summary>
    ///     Whether the command was executed successfully.
    /// </summary>
    [JsonPropertyName("SetBalanceTableURL")]
    public bool SetBalanceTableUrl { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return SetBalanceTableUrl;
    }
}