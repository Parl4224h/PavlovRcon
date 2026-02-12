namespace PavlovRcon.GameData;

/// <summary>
///     Miscellaneous items.
/// </summary>
public enum MiscItem
{
    /// <summary>
    ///     Body Armor
    /// </summary>
    [RconId("armour")] Kevlar = 0,

    /// <summary>
    ///     Body Armor and Helmet
    /// </summary>
    [RconId("kevlarhelmet")] KevlarAndHelmet = 1,

    /// <summary>
    ///     SND defusal wire cutters
    /// </summary>
    [RconId("pliers")] Clips = 2,

    /// <summary>
    ///     Knife
    /// </summary>
    [RconId("knife")] Knife = 3,

    /// <summary>
    ///     Taser
    /// </summary>
    [RconId("taser")] Taser = 4,

    /// <summary>
    ///     Crowbar
    /// </summary>
    [RconId("crowbar")] Crowbar = 5,

    /// <summary>
    ///     Bolt Cutters
    /// </summary>
    [RconId("boltcutters")] BoltCutters = 6,

    /// <summary>
    ///     Lock pick
    /// </summary>
    [RconId("lockpick")] LockPick = 7,

    /// <summary>
    ///     Handcuffs
    /// </summary>
    [RconId("handcuffs")] HandCuffs = 8,

    /// <summary>
    ///     Repair Tool
    /// </summary>
    [RconId("repairtool")] RepairTool = 9,

    /// <summary>
    ///     Pickaxe
    /// </summary>
    [RconId("pickaxe")] Pickaxe = 10,

    /// <summary>
    ///     Keycard
    /// </summary>
    [RconId("keycard")] Keycard = 11,

    /// <summary>
    ///     WW2 knife
    /// </summary>
    [RconId("ww2knife")] WW2Knife = 12,

    /// <summary>
    ///     Snowball acts like a knife once thrown
    /// </summary>
    [RconId("snowball")] Snowball = 13
}
