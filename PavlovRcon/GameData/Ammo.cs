namespace PavlovRcon.GameData;

/// <summary>
///     Ammo types for weapons.
/// </summary>
public enum Ammo
{
    /// <summary>
    ///     Ammo for Rifles
    /// </summary>
    [RconId("ammo_rifle")] Rifle,

    /// <summary>
    ///     Ammo for Snipers
    /// </summary>
    [RconId("ammo_sniper")] Sniper,

    /// <summary>
    ///     Ammo for SMGs
    /// </summary>
    [RconId("ammo_smg")] Smg,

    /// <summary>
    ///     Ammo for Pistols
    /// </summary>
    [RconId("ammo_pistol")] Pistol,

    /// <summary>
    ///     Ammo for Shotguns
    /// </summary>
    [RconId("ammo_shotgun")] Shotgun,

    /// <summary>
    ///     Ammo for special weapons
    /// </summary>
    [RconId("ammo_special")] Special,

    /// <summary>
    ///     Ammo for other weapons
    /// </summary>
    [RconId("ammo_other")] Other
}