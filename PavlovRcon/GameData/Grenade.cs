namespace PavlovRcon.GameData;

/// <summary>
/// Grenade types.
/// </summary>
public enum Grenade
{
    /// <summary>
    /// Explosive grenade.
    /// </summary>
    [RconId("grenade")] Grenade,
    /// <summary>
    /// Explosive grenade, Russian variant.
    /// </summary>
    [RconId("grenade_ru")] GrenadeRussia,
    /// <summary>
    /// Explosive grenade, US variant.
    /// </summary>
    [RconId("grenade_us")] GrenadeUS,
    /// <summary>
    /// Explosive grenade, German variant.
    /// </summary>
    [RconId("grenade_ger")] GrenadeGermany,
    /// <summary>
    /// Explosive grenade, Soviet variant.
    /// </summary>
    [RconId("grenade_svt")] GrenadeSoviet,
    /// <summary>
    /// Explosive grenade, Aurora variant.
    /// </summary>
    [RconId("grenade_aurora")] GrenadeAurora,
    /// <summary>
    /// Discombobulation grenade.
    /// </summary>
    [RconId("grenade_dis")] GrenadeDiscombobulation,
    /// <summary>
    /// Smoke grenade.
    /// </summary>
    [RconId("smoke")] Smoke,
    /// <summary>
    /// Smoke grenade, Russian variant.
    /// </summary>
    [RconId("smoke_ru")] SmokeRussia,
    /// <summary>
    /// Smoke grenade, US variant.
    /// </summary>
    [RconId("smoke_us")] SmokeUS,
    /// <summary>
    /// Smoke grenade, German variant.
    /// </summary>
    [RconId("smoke_ger")] SmokeGermany,
    /// <summary>
    /// Smoke grenade, Soviet variant.
    /// </summary>
    [RconId("smoke_svt")] SmokeSoviet,
    /// <summary>
    /// Flashbang grenade.
    /// </summary>
    [RconId("flash")] Flash,
    /// <summary>
    /// Flashbang grenade, Aurora variant.
    /// </summary>
    [RconId("flash_aurora")] FlashAurora
}