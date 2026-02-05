namespace PavlovRcon.GameData;

/// <summary>
/// Items for the Push game mode
/// </summary>
public enum PushItem
{
    /// <summary>
    /// Push bomb
    /// </summary>
    [RconId("pushbomb")] Bomb,
    /// <summary>
    /// Anti-tank mine
    /// </summary>
    [RconId("antitankmine")] AntiTankMine,
    /// <summary>
    /// Anti-personnel mine
    /// </summary>
    [RconId("antipersonnelmine")] AntiPersonnelMine,
    /// <summary>
    /// Ammo crate
    /// </summary>
    [RconId("ammocrate")] AmmoCrate
}