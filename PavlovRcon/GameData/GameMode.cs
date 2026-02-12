using System.Text.Json.Serialization;

namespace PavlovRcon.GameData;

/// <summary>
///     Game modes supported by the game.
/// </summary>
[JsonConverter(typeof(RconIdEnumJsonConverter<GameMode>))]
public enum GameMode
{
    /// <summary>
    ///     The deathmatch game mode.
    /// </summary>
    [RconId("DM")] DeathMatch = 0,

    /// <summary>
    ///     The gun game mode.
    /// </summary>
    [RconId("GUN")] GunGame = 1,

    /// <summary>
    ///     The hidden infection game mode.
    /// </summary>
    [RconId("INFECTION")] HiddenInfection = 2,

    /// <summary>
    ///     The king of the hill game mode.
    /// </summary>
    [RconId("KOTH")] KingOfTheHill = 3,

    /// <summary>
    ///     The one in the chamber game mode.
    /// </summary>
    [RconId("OITC")] OneInTheChamber = 4,

    /// <summary>
    ///     The prop hunt game mode.
    /// </summary>
    [RconId("PH")] PropHunt = 5,

    /// <summary>
    ///     The push game mode.
    /// </summary>
    [RconId("PUSH")] Push = 6,

    /// <summary>
    ///     The search and destroy game mode.
    /// </summary>
    [RconId("SND")] SearchAndDestroy = 7,

    /// <summary>
    ///     The team deathmatch game mode.
    /// </summary>
    [RconId("TDM")] TeamDeathMatch = 8,

    /// <summary>
    ///     The hidden game mode.
    /// </summary>
    [RconId("HIDE")] TheHidden = 9,

    /// <summary>
    ///     The TTT game mode.
    /// </summary>
    [RconId("TTT")] TroubleInTerroristTown = 10,

    /// <summary>
    ///     The TTT classic game mode.
    /// </summary>
    [RconId("TTTclassic")] TroubleInTerroristTownClassic = 11,

    /// <summary>
    ///     The WW2 gun game mode.
    /// </summary>
    [RconId("WW2GUN")] WW2GunGame = 12,

    /// <summary>
    ///     The WW2 team deathmatch game mode.
    /// </summary>
    [RconId("WW2TDM")] WW2TeamDeathMatch = 13,

    /// <summary>
    ///     The zombie wave survival game mode.
    /// </summary>
    [RconId("ZWV")] ZombieWaveSurvival = 14
}