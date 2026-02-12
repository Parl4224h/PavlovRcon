namespace PavlovRcon.GameData;

/// <summary>
///     Heavy weapons.
/// </summary>
public enum Heavy
{
    /// <summary>
    ///     Pump Shotgun
    /// </summary>
    [RconId("shotgun")] PumpShotgun = 0,

    /// <summary>
    ///     Sawed-off Shotgun
    /// </summary>
    [RconId("sawedoff")] SawedOff = 1,

    /// <summary>
    ///     M249 Machine Gun
    /// </summary>
    [RconId("lmga")] M249 = 2,

    /// <summary>
    ///     Spas-12 shotgun
    /// </summary>
    [RconId("autoshotgun")] Spas12 = 3,

    /// <summary>
    ///     Saiga-12 Shotgun
    /// </summary>
    [RconId("drumshotgun")] Saiga12 = 4,

    /// <summary>
    ///     MG-42 Machine Gun
    /// </summary>
    [RconId("mg42")] MG42 = 5,

    /// <summary>
    ///     Trench Shotgun
    /// </summary>
    [RconId("trenchgun")] TrenchShotgun = 6,

    /// <summary>
    ///     PKM Machine Gun
    /// </summary>
    [RconId("pkm")] PKM = 7
}
