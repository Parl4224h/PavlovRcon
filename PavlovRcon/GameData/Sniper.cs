namespace PavlovRcon.GameData;

/// <summary>
///     Snipers.
/// </summary>
public enum Sniper
{
    /// <summary>
    ///     AWP
    /// </summary>
    [RconId("awp")] AWP = 0,

    /// <summary>
    ///     Barrett M99
    /// </summary>
    [RconId("antitank")] BarrettM99 = 1,

    /// <summary>
    ///     Kar98k
    /// </summary>
    [RconId("kar98")] Kar98 = 2,

    /// <summary>
    ///     SCAR-20
    /// </summary>
    [RconId("scur")] SCAR20 = 3,

    /// <summary>
    ///     Mosin-Nagant
    /// </summary>
    [RconId("mosin")] Mosin = 4,

    /// <summary>
    ///     Springfield
    /// </summary>
    [RconId("springfield")] Springfield = 5,

    /// <summary>
    ///     Lee Enfield
    /// </summary>
    [RconId("leeenfield")] LeeEnfield = 6,

    /// <summary>
    ///     G3
    /// </summary>
    [RconId("autosniper")] G3 = 7,

    /// <summary>
    ///     Hunting Rifle
    /// </summary>
    [RconId("hunting")] HuntingRifle = 8
}
