namespace PavlovRcon.GameData;

/// <summary>
///     Items for the Push game mode
/// </summary>
public enum PushItem
{
    /// <summary>
    ///     Push bomb
    /// </summary>
    [RconId("pushbomb")] Bomb = 0,

    /// <summary>
    ///     Anti-tank mine
    /// </summary>
    [RconId("antitankmine")] AntiTankMine = 1,

    /// <summary>
    ///     Anti-personnel mine
    /// </summary>
    [RconId("antipersonnelmine")] AntiPersonnelMine = 2,

    /// <summary>
    ///     Ammo crate
    /// </summary>
    [RconId("ammocrate")] AmmoCrate = 3
}
