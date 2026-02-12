namespace PavlovRcon.GameData;

/// <summary>
///     Grenade types.
/// </summary>
public enum Grenade
{
    /// <summary>
    ///     Explosive grenade.
    /// </summary>
    [RconId("grenade")] Grenade = 0,

    /// <summary>
    ///     Explosive grenade, Russian variant.
    /// </summary>
    [RconId("grenade_ru")] GrenadeRussia = 1,

    /// <summary>
    ///     Explosive grenade, US variant.
    /// </summary>
    [RconId("grenade_us")] GrenadeUS = 2,

    /// <summary>
    ///     Explosive grenade, German variant.
    /// </summary>
    [RconId("grenade_ger")] GrenadeGermany = 3,

    /// <summary>
    ///     Explosive grenade, Soviet variant.
    /// </summary>
    [RconId("grenade_svt")] GrenadeSoviet = 4,

    /// <summary>
    ///     Explosive grenade, Aurora variant.
    /// </summary>
    [RconId("grenade_aurora")] GrenadeAurora = 5,

    /// <summary>
    ///     Discombobulation grenade.
    /// </summary>
    [RconId("grenade_dis")] GrenadeDiscombobulation = 6,

    /// <summary>
    ///     Smoke grenade.
    /// </summary>
    [RconId("smoke")] Smoke = 7,

    /// <summary>
    ///     Smoke grenade, Russian variant.
    /// </summary>
    [RconId("smoke_ru")] SmokeRussia = 8,

    /// <summary>
    ///     Smoke grenade, US variant.
    /// </summary>
    [RconId("smoke_us")] SmokeUS = 9,

    /// <summary>
    ///     Smoke grenade, German variant.
    /// </summary>
    [RconId("smoke_ger")] SmokeGermany = 10,

    /// <summary>
    ///     Smoke grenade, Soviet variant.
    /// </summary>
    [RconId("smoke_svt")] SmokeSoviet = 11,

    /// <summary>
    ///     Flashbang grenade.
    /// </summary>
    [RconId("flash")] Flash = 12,

    /// <summary>
    ///     Flashbang grenade, Aurora variant.
    /// </summary>
    [RconId("flash_aurora")] FlashAurora = 13
}
