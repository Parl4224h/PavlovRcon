using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
/// The base class for all RCON responses.
/// </summary>
public class RconResponseBase
{
    /// <summary>
    /// The command that was sent.
    /// </summary>
    [JsonPropertyName("Command")] public string Command { get; set; } = null!;
    
    /// <summary>
    /// Whether the command was successful.
    /// </summary>
    [JsonPropertyName("Successful")] public bool Successful { get; set; }
}

/// <summary>
/// A successful RCON response.
/// </summary>
public sealed class RconOkResponse : RconResponseBase;