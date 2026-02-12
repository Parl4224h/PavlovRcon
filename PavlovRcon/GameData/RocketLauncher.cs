namespace PavlovRcon.GameData;

/// <summary>
///     Rocket Launchers.
/// </summary>
public enum RocketLauncher
{
    /// <summary>
    ///     RPG-7
    /// </summary>
    [RconId("rl_rpg")] RPG7 = 0,

    /// <summary>
    ///     Panzerschreck
    /// </summary>
    [RconId("rl_panzer")] Panzerschreck = 1,

    /// <summary>
    ///     M1 Bazooka
    /// </summary>
    [RconId("rl_m1ma1")] M1Bazooka = 2,

    /// <summary>
    ///     PIAT
    /// </summary>
    [RconId("rl_piat")] PIAT = 3
}
