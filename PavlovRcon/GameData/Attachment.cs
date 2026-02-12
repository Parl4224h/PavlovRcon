namespace PavlovRcon.GameData;

/// <summary>
///     Attachments for weapons.
/// </summary>
public enum Attachment
{
    /// <summary>
    ///     Suppressor for pistols.
    /// </summary>
    [RconId("supp_pistol")] PistolSuppressor = 0,

    /// <summary>
    ///     Suppressor for rifles.
    /// </summary>
    [RconId("supp_rifle")] RifleSuppressor = 1,

    /// <summary>
    ///     8X optical scope (sniper scope).
    /// </summary>
    [RconId("scope")] X8Scope = 2,

    /// <summary>
    ///     Angled grip.
    /// </summary>
    [RconId("grip_angled")] AngledGrip = 3,

    /// <summary>
    ///     Vertical grip.
    /// </summary>
    [RconId("grip_vertical")] VerticalGrip = 4,

    /// <summary>
    ///     4X ACOG style scope.
    /// </summary>
    [RconId("acog")] Acog = 5,

    /// <summary>
    ///     Holographic sight.
    /// </summary>
    [RconId("holo")] Holographic = 6,

    /// <summary>
    ///     Red dot sight for rifles.
    /// </summary>
    [RconId("reddot")] RifleRedDot = 7,

    /// <summary>
    ///     Flashlight for rifles.
    /// </summary>
    [RconId("flashlight_rifle")] RifleFlashlight = 8,

    /// <summary>
    ///     Laser for rifles.
    /// </summary>
    [RconId("laser_rifle")] RifleLaser = 9,

    /// <summary>
    ///     Laser for pistols.
    /// </summary>
    [RconId("laser_pistol")] PistolLaser = 10,

    /// <summary>
    ///     8X optical scope from the Kar98 rifle.
    /// </summary>
    [RconId("scope_kar98")] Kar98Scope = 11,

    /// <summary>
    ///     4X optical scope from the Lee Enfield rifle.
    /// </summary>
    [RconId("scope_leeenfield")] LeeEnfieldScope = 12,

    /// <summary>
    ///     8X optical scope from the Springfield rifle.
    /// </summary>
    [RconId("scope_springfield")] SpringfieldScope = 13,

    /// <summary>
    ///     4X optical scope from the Mosin rifle.
    /// </summary>
    [RconId("scope_mosin")] MosinScope = 14,

    /// <summary>
    ///     Bayonet with trenchgun styling
    /// </summary>
    [RconId("bayonet_trenchgun")] TrenchGunBayonet = 15,

    /// <summary>
    ///     Bayonet with Lee Enfield styling
    /// </summary>
    [RconId("bayonet_leeenfield")] LeeEnfieldBayonet = 16,

    /// <summary>
    ///     Bayonet with M1 Garand styling
    /// </summary>
    [RconId("bayonet_m1garand")] M1GarandBayonet = 17,

    /// <summary>
    ///     Bayonet with Mosin styling
    /// </summary>
    [RconId("bayonet_mosin")] MosinBayonet = 18,

    /// <summary>
    ///     Bayonet with Springfield styling
    /// </summary>
    [RconId("bayonet_springfield")] SpringfieldBayonet = 19,

    /// <summary>
    ///     Bayonet with Kar98 styling
    /// </summary>
    [RconId("bayonet_kar98")] Kar98Bayonet = 20,

    /// <summary>
    ///     Canted red dot sight for rifles.
    /// </summary>
    [RconId("canted_reddot")] RifleRedDotCanted = 21,

    /// <summary>
    ///     Red dot sight for pistols.
    /// </summary>
    [RconId("reddot_pistol")] PistolRedDot = 22
}
