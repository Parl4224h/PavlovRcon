namespace PavlovRcon.GameData;

public enum Attachment
{
    [RconId("supp_pistol")] PistolSuppressor,
    [RconId("supp_rifle")] RifleSuppressor,
    [RconId("scope")] X8Scope,
    [RconId("grip_angled")] AngledGrip,
    [RconId("grip_vertical")] VerticalGrip,
    [RconId("acog")] ACOG,
    [RconId("holo")] Holographic,
    [RconId("reddot")] RifleRedDot,
    [RconId("flashlight_rifle")] RifleFlashlight,
    [RconId("laser_rifle")] RifleLaser,
    [RconId("laser_pistol")] PistolLaser,
    [RconId("scope_kar98")] Kar98Scope,
    [RconId("scope_leeenfield")] LeeEnfieldScope,
    [RconId("scope_springfield")] SpringfieldScope,
    [RconId("scope_mosin")] MosinScope,
    [RconId("bayonet_trenchgun")] TrenchGunBayonet,
    [RconId("bayonet_leeenfield")] LeeEnfieldBayonet,
    [RconId("bayonet_m1garand")] M1GarandBayonet,
    [RconId("bayonet_mosin")] MosinBayonet,
    [RconId("bayonet_springfield")] SpringfieldBayonet,
    [RconId("bayonet_kar98")] Kar98Bayonet,
    [RconId("canted_reddot")] RifleRedDotCanted,
    [RconId("reddot_pistol")] PistolRedDot
}