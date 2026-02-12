namespace PavlovRcon.GameData;

/// <summary>
///     Roles for the TTT game mode
/// </summary>
public enum TttRole
{
    /// <summary>
    ///     The detective role.
    /// </summary>
    [RconId("Detective")] Detective = 0,

    /// <summary>
    ///     The sheriff role.
    /// </summary>
    [RconId("Sheriff")] Sheriff = 1,

    /// <summary>
    ///     The tank role.
    /// </summary>
    [RconId("Tank")] Tank = 2,

    /// <summary>
    ///     The innocent role.
    /// </summary>
    [RconId("Innocent")] Innocent = 3,

    /// <summary>
    ///     The mercenary role.
    /// </summary>
    [RconId("Mercenary")] Mercenary = 4,

    /// <summary>
    ///     The survivalist role.
    /// </summary>
    [RconId("Survivalist")] Survivalist = 5,

    /// <summary>
    ///     The glitch role.
    /// </summary>
    [RconId("Glitch")] Glitch = 6,

    /// <summary>
    ///     The jester role.
    /// </summary>
    [RconId("Jester")] Jester = 7,

    /// <summary>
    ///     The psychopath role.
    /// </summary>
    [RconId("Psychopath")] Psychopath = 8,

    /// <summary>
    ///     The lone wolf role.
    /// </summary>
    [RconId("Lone Wolf")] LoneWolf = 9,

    /// <summary>
    ///     The traitor role.
    /// </summary>
    [RconId("Traitor")] Traitor = 10,

    /// <summary>
    ///     The hypnotist role.
    /// </summary>
    [RconId("Hypnotist")] Hypnotist = 11,

    /// <summary>
    ///     The soulmate role.
    /// </summary>
    [RconId("Soulmate")] Soulmate = 12,

    /// <summary>
    ///     The zombie role.
    /// </summary>
    [RconId("Zombie")] Zombie = 13
}
