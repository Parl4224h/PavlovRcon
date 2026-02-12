namespace PavlovRcon.GameData;

/// <summary>
///     Ammo types for weapons.
/// </summary>
public enum Ammo
{
    /// <summary>
    ///     Ammo for Rifles
    /// </summary>
    [RconId("ammo_rifle")] Rifle = 0,

    /// <summary>
    ///     Ammo for Snipers
    /// </summary>
    [RconId("ammo_sniper")] Sniper = 1,

    /// <summary>
    ///     Ammo for SMGs
    /// </summary>
    [RconId("ammo_smg")] Smg = 2,

    /// <summary>
    ///     Ammo for Pistols
    /// </summary>
    [RconId("ammo_pistol")] Pistol = 3,

    /// <summary>
    ///     Ammo for Shotguns
    /// </summary>
    [RconId("ammo_shotgun")] Shotgun = 4,

    /// <summary>
    ///     Ammo for special weapons
    /// </summary>
    [RconId("ammo_special")] Special = 5,

    /// <summary>
    ///     Ammo for other weapons
    /// </summary>
    [RconId("ammo_other")] Other = 6
}
