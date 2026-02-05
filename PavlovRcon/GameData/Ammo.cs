namespace PavlovRcon.GameData;

public enum Ammo
{
    [RconId("ammo_rifle")] Rifle,
    [RconId("ammo_sniper")] Sniper,
    [RconId("ammo_smg")] SMG,
    [RconId("ammo_pistol")] Pistol,
    [RconId("ammo_shotgun")] Shotgun,
    [RconId("ammo_special")] Special,
    [RconId("ammo_other")] Other
}