namespace PavlovRcon.GameData;

/// <summary>
/// Attachments for weapons.
/// </summary>
public enum Attachment
{
    /// <summary>
    /// Suppressor for pistols.
    /// </summary>
    [RconId("supp_pistol")] PistolSuppressor,
    /// <summary>
    /// Suppressor for rifles.
    /// </summary>
    [RconId("supp_rifle")] RifleSuppressor,
    /// <summary>
    /// 8X optical scope (sniper scope).
    /// </summary>
    [RconId("scope")] X8Scope,
    /// <summary>
    /// Angled grip.
    /// </summary>
    [RconId("grip_angled")] AngledGrip,
    /// <summary>
    /// Vertical grip.
    /// </summary>
    [RconId("grip_vertical")] VerticalGrip,
    /// <summary>
    /// 4X ACOG style scope.
    /// </summary>
    [RconId("acog")] Acog,
    /// <summary>
    /// Holographic sight.
    /// </summary>
    [RconId("holo")] Holographic,
    /// <summary>
    /// Red dot sight for rifles.
    /// </summary>
    [RconId("reddot")] RifleRedDot,
    /// <summary>
    /// Flashlight for rifles.
    /// </summary>
    [RconId("flashlight_rifle")] RifleFlashlight,
    /// <summary>
    /// Laser for rifles.
    /// </summary>
    [RconId("laser_rifle")] RifleLaser,
    /// <summary>
    /// Laser for pistols.
    /// </summary>
    [RconId("laser_pistol")] PistolLaser,
    /// <summary>
    /// 8X optical scope from the Kar98 rifle.
    /// </summary>
    [RconId("scope_kar98")] Kar98Scope,
    /// <summary>
    /// 4X optical scope from the Lee Enfield rifle.
    /// </summary>
    [RconId("scope_leeenfield")] LeeEnfieldScope,
    /// <summary>
    /// 8X optical scope from the Springfield rifle.
    /// </summary>
    [RconId("scope_springfield")] SpringfieldScope,
    /// <summary>
    /// 4X optical scope from the Mosin rifle.
    /// </summary>
    [RconId("scope_mosin")] MosinScope,
    /// <summary>
    /// Bayonet with trenchgun styling
    /// </summary>
    [RconId("bayonet_trenchgun")] TrenchGunBayonet,
    /// <summary>
    /// Bayonet with Lee Enfield styling
    /// </summary>
    [RconId("bayonet_leeenfield")] LeeEnfieldBayonet,
    /// <summary>
    /// Bayonet with M1 Garand styling
    /// </summary>
    [RconId("bayonet_m1garand")] M1GarandBayonet,
    /// <summary>
    /// Bayonet with Mosin styling
    /// </summary>
    [RconId("bayonet_mosin")] MosinBayonet,
    /// <summary>
    /// Bayonet with Springfield styling
    /// </summary>
    [RconId("bayonet_springfield")] SpringfieldBayonet,
    /// <summary>
    /// Bayonet with Kar98 styling
    /// </summary>
    [RconId("bayonet_kar98")] Kar98Bayonet,
    /// <summary>
    /// Canted red dot sight for rifles.
    /// </summary>
    [RconId("canted_reddot")] RifleRedDotCanted,
    /// <summary>
    /// Red dot sight for pistols.
    /// </summary>
    [RconId("reddot_pistol")] PistolRedDot
}