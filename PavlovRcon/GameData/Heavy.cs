namespace PavlovRcon.GameData;

/// <summary>
/// Heavy weapons.
/// </summary>
public enum Heavy
{
    /// <summary>
    /// Pump Shotgun
    /// </summary>
    [RconId("shotgun")] PumpShotgun,
    /// <summary>
    /// Sawed-off Shotgun
    /// </summary>
    [RconId("sawedoff")] SawedOff,
    /// <summary>
    /// M249 Machine Gun
    /// </summary>
    [RconId("lmga")] M249,
    /// <summary>
    /// Spas-12 shotgun
    /// </summary>
    [RconId("autoshotgun")] Spas12,
    /// <summary>
    /// Saiga-12 Shotgun
    /// </summary>
    [RconId("drumshotgun")] Saiga12,
    /// <summary>
    /// MG-42 Machine Gun
    /// </summary>
    [RconId("mg42")] MG42,
    /// <summary>
    /// Trench Shotgun
    /// </summary>
    [RconId("trenchgun")] TrenchShotgun,
    /// <summary>
    /// PKM Machine Gun
    /// </summary>
    [RconId("pkm")] PKM
}