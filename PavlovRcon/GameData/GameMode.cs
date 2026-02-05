namespace PavlovRcon.GameData;

/// <summary>
/// Game modes supported by the game.
/// </summary>
public enum GameMode
{
    /// <summary>
    /// The deathmatch game mode.
    /// </summary>
    [RconId("DM")]
    DeathMatch,

    /// <summary>
    /// The gun game mode.
    /// </summary>
    [RconId("GUN")]
    GunGame,

    /// <summary>
    /// The hidden infection game mode.
    /// </summary>
    [RconId("INFECTION")]
    HiddenInfection,

    /// <summary>
    /// The king of the hill game mode.
    /// </summary>
    [RconId("KOTH")]
    KingOfTheHill,

    /// <summary>
    /// The one in the chamber game mode.
    /// </summary>
    [RconId("OITC")]
    OneInTheChamber,

    /// <summary>
    /// The prop hunt game mode.
    /// </summary>
    [RconId("PH")]
    PropHunt,

    /// <summary>
    /// The push game mode.
    /// </summary>
    [RconId("PUSH")]
    Push,

    /// <summary>
    /// The search and destroy game mode.
    /// </summary>
    [RconId("SND")]
    SearchAndDestroy,

    /// <summary>
    /// The team deathmatch game mode.
    /// </summary>
    [RconId("TDM")]
    TeamDeathMatch,

    /// <summary>
    /// The hidden game mode.
    /// </summary>
    [RconId("HIDE")]
    TheHidden,

    /// <summary>
    /// The TTT game mode.
    /// </summary>
    [RconId("TTT")]
    TroubleInTerroristTown,

    /// <summary>
    /// The TTT classic game mode.
    /// </summary>
    [RconId("TTTclassic")]
    TroubleInTerroristTownClassic,

    /// <summary>
    /// The WW2 gun game mode.
    /// </summary>
    [RconId("WW2GUN")]
    WW2GunGame,

    /// <summary>
    /// The WW2 team deathmatch game mode.
    /// </summary>
    [RconId("WW2TDM")]
    WW2TeamDeathMatch,

    /// <summary>
    /// The zombie wave survival game mode.
    /// </summary>
    [RconId("ZWV")]
    ZombieWaveSurvival,
}


