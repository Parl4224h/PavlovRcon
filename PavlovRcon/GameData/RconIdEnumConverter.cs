using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PavlovRcon.GameData;

/// <summary>
///     JSON converter for enums with the RconId attribute.
/// </summary>
/// <typeparam name="TEnum">The enum type to convert.</typeparam>
public sealed class RconIdEnumJsonConverter<TEnum> : JsonConverter<TEnum>
    where TEnum : struct, Enum
{
    private static readonly Dictionary<string, TEnum> FromRconId;
    private static readonly Dictionary<TEnum, string> ToRconId;

    static RconIdEnumJsonConverter()
    {
        FromRconId = new Dictionary<string, TEnum>(StringComparer.OrdinalIgnoreCase);
        ToRconId = new Dictionary<TEnum, string>();

        foreach (var field in typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            var attr = field.GetCustomAttribute<RconIdAttribute>();
            if (attr is null)
                continue;

            var value = (TEnum)field.GetValue(null)!;
            FromRconId[attr.Id] = value;
            ToRconId[value] = attr.Id;
        }
    }

    /// <inheritdoc />
    public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var rconId = reader.GetString();

        if (rconId is null || !FromRconId.TryGetValue(rconId, out var value))
            throw new JsonException($"Unknown RconId '{rconId}' for enum {typeof(TEnum).Name}");

        return value;
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
    {
        if (!ToRconId.TryGetValue(value, out var rconId))
            throw new JsonException($"Missing RconId for enum value {value}");

        writer.WriteStringValue(rconId);
    }
}