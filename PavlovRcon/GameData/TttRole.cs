namespace PavlovRcon.GameData;

/// <summary>
///     Roles for the TTT game mode
/// </summary>
public enum TttRole
{
    /// <summary>
    ///     The detective role.
    /// </summary>
    [RconId("Detective")] Detective,

    /// <summary>
    ///     The sheriff role.
    /// </summary>
    [RconId("Sheriff")] Sheriff,

    /// <summary>
    ///     The tank role.
    /// </summary>
    [RconId("Tank")] Tank,

    /// <summary>
    ///     The innocent role.
    /// </summary>
    [RconId("Innocent")] Innocent,

    /// <summary>
    ///     The mercenary role.
    /// </summary>
    [RconId("Mercenary")] Mercenary,

    /// <summary>
    ///     The survivalist role.
    /// </summary>
    [RconId("Survivalist")] Survivalist,

    /// <summary>
    ///     The glitch role.
    /// </summary>
    [RconId("Glitch")] Glitch,

    /// <summary>
    ///     The jester role.
    /// </summary>
    [RconId("Jester")] Jester,

    /// <summary>
    ///     The psychopath role.
    /// </summary>
    [RconId("Psychopath")] Psychopath,

    /// <summary>
    ///     The lone wolf role.
    /// </summary>
    [RconId("Lone Wolf")] LoneWolf,

    /// <summary>
    ///     The traitor role.
    /// </summary>
    [RconId("Traitor")] Traitor,

    /// <summary>
    ///     The hypnotist role.
    /// </summary>
    [RconId("Hypnotist")] Hypnotist,

    /// <summary>
    ///     The soulmate role.
    /// </summary>
    [RconId("Soulmate")] Soulmate,

    /// <summary>
    ///     The zombie role.
    /// </summary>
    [RconId("Zombie")] Zombie
}