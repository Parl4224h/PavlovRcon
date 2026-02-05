using System.Collections.Concurrent;
using System.Reflection;

namespace PavlovRcon.GameData;

/// <summary>
///     Extension method for getting the RCON ID of an enum value.
/// </summary>
public static class RconEnumExtensions
{
    private static readonly ConcurrentDictionary<Enum, string> Cache = new();

    /// <summary>
    ///     Gets the RCON ID of an enum value.
    /// </summary>
    /// <param name="value">The enum value to get the RCON ID for</param>
    /// <returns>The RCON ID of the enum value</returns>
    /// <exception cref="InvalidOperationException">Thrown if the enum value has no RconIdAttribute</exception>
    public static string ToRconId(this Enum value)
    {
        return Cache.GetOrAdd(value, v =>
        {
            var member = v.GetType().GetMember(v.ToString())[0];
            var attr = member.GetCustomAttribute<RconIdAttribute>();

            if (attr is null)
                throw new InvalidOperationException(
                    $"Enum value {v.GetType().Name}.{v} has no RconIdAttribute.");

            return attr.Id;
        });
    }
}