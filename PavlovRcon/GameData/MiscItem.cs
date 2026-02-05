namespace PavlovRcon.GameData;

/// <summary>
/// Miscellaneous items.
/// </summary>
public enum MiscItem
{
    /// <summary>
    /// Body Armor
    /// </summary>
    [RconId("armour")] Kevlar,
    /// <summary>
    /// Body Armor and Helmet
    /// </summary>
    [RconId("kevlarhelmet")] KevlarAndHelmet,
    /// <summary>
    /// SND defusal wire cutters
    /// </summary>
    [RconId("pliers")] Clips,
    /// <summary>
    /// Knife
    /// </summary>
    [RconId("knife")] Knife,
    /// <summary>
    /// Taser
    /// </summary>
    [RconId("taser")] Taser,
    /// <summary>
    /// Crowbar
    /// </summary>
    [RconId("crowbar")] Crowbar,
    /// <summary>
    /// Bolt Cutters
    /// </summary>
    [RconId("boltcutters")] BoltCutters,
    /// <summary>
    /// Lock pick
    /// </summary>
    [RconId("lockpick")] LockPick,
    /// <summary>
    /// Handcuffs
    /// </summary>
    [RconId("handcuffs")] HandCuffs,
    /// <summary>
    /// Repair Tool
    /// </summary>
    [RconId("repairtool")] RepairTool,
    /// <summary>
    /// Pickaxe
    /// </summary>
    [RconId("pickaxe")] Pickaxe,
    /// <summary>
    /// Keycard
    /// </summary>
    [RconId("keycard")] Keycard,
    /// <summary>
    /// WW2 knife
    /// </summary>
    [RconId("ww2knife")] WW2Knife,
    /// <summary>
    /// Snowball acts like a knife once thrown
    /// </summary>
    [RconId("snowball")] Snowball
}