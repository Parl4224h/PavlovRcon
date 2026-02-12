using System.Text.Json.Serialization;

namespace PavlovRcon.GameData;

/// <summary>
///     Ammo types supported for Ammo modes
/// </summary>
[JsonConverter(typeof(RconIdEnumJsonConverter<AmmoType>))]
public enum AmmoType
{
    /// <summary>
    ///     Unlimited ammo.
    /// </summary>
    [RconId("0")] Unlimited = 0,

    /// <summary>
    ///     Limited ammo that is global across all weapons.
    /// </summary>
    [RconId("1")] LimitedGeneric = 1,

    /// <summary>
    ///     Limited ammo that is specific to certain weapons.
    /// </summary>
    [RconId("2")] LimitedSpecific = 2,

    /// <summary>
    ///     Custom ammo limits specified by game mode or mods
    /// </summary>
    [RconId("3")] Custom = 3,

    /// <summary>
    ///     All weapons except for Special weapons have limited ammo.
    /// </summary>
    [RconId("4")] LimitedSpecial = 4,

    /// <summary>
    ///     Same as LimitedSpecial, but ammo is not in boxes.
    /// </summary>
    [RconId("5")] Boxless = 5
}
