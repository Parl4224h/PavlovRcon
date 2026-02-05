using System.Text.Json.Serialization;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the ItemList command.
/// </summary>
public class ItemListResponse : RconResponseBase
{
    /// <summary>
    ///     The list of items in the server.
    /// </summary>
    [JsonPropertyName("ItemList")]
    public List<string> ItemList { get; set; } = [];

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return Successful;
    }
}