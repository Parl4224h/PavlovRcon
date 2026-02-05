using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     The base class for all RCON responses.
/// </summary>
public abstract class RconResponseBase
{
    /// <summary>
    ///     The command that was sent.
    /// </summary>
    [JsonPropertyName("Command")]
    public string Command { get; set; } = null!;

    /// <summary>
    ///     Whether the server successfully executed the command.
    /// </summary>
    /// <remarks>
    ///     This does not guarantee the server updated its state. The field that is the name of the command should be relied
    ///     upon for verifying that the command successfully updated the server state. For commands that have a second state
    ///     for success the additional property <see cref="WasSuccessful"/> is pointed at that value instead of the general
    ///     Success flag.
    /// </remarks>
    [JsonPropertyName("Successful")]
    public bool Successful { get; set; }

    /// <summary>
    ///     Indicates whether the command succeeded.
    ///     Not serialized.
    /// </summary>
    [JsonIgnore]
    public bool WasSuccessful => EvaluateSuccess();

    /// <summary>
    ///     Evaluates whether the command succeeded.
    /// </summary>
    /// <returns></returns>
    protected abstract bool EvaluateSuccess();
}

/// <summary>
///     A successful RCON response.
/// </summary>
public sealed class RconOkResponse : RconResponseBase
{
    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Successful;
    }
}