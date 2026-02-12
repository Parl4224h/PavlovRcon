namespace PavlovRcon.GameData;

/// <summary>
///     Medical items.
/// </summary>
public enum MedicalItem
{
    /// <summary>
    ///     Painkiller bottle
    /// </summary>
    [RconId("painkillers")] Painkillers = 0,

    /// <summary>
    ///     WW2 healing syringe
    /// </summary>
    [RconId("ww2syringe")] WW2Syringe = 1,

    /// <summary>
    ///     Medical Kit
    /// </summary>
    [RconId("medkit")] MedKit = 2,

    /// <summary>
    ///     Bandage
    /// </summary>
    [RconId("bandage")] Bandage = 3,

    /// <summary>
    ///     WW2 Medical Kit
    /// </summary>
    [RconId("ww2medkit")] WW2MedKit = 4,

    /// <summary>
    ///     Healing syringe
    /// </summary>
    [RconId("syringe")] Syringe = 5,

    /// <summary>
    ///     WW2 Painkiller bottle
    /// </summary>
    [RconId("ww2painkillers")] WW2Painkillers = 6,

    /// <summary>
    ///     WW2 Bandage
    /// </summary>
    [RconId("ww2bandage")] WW2Bandage = 7
}
