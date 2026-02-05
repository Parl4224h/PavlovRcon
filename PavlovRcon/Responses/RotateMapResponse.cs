using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the RotateMap command.
/// </summary>
public class RotateMapResponse : RconResponseBase
{
    /// <summary>
    ///     Whether the map rotation was successful.
    /// </summary>
    [JsonPropertyName("RotateMap")]
    public bool RotateMap { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return RotateMap;
    }
}