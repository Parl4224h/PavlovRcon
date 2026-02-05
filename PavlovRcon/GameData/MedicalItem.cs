namespace PavlovRcon.GameData;

/// <summary>
/// Medical items.
/// </summary>
public enum MedicalItem
{
    /// <summary>
    /// Painkiller bottle
    /// </summary>
    [RconId("painkillers")] Painkillers,
    /// <summary>
    /// WW2 healing syringe
    /// </summary>
    [RconId("ww2syringe")] WW2Syringe,
    /// <summary>
    /// Medical Kit
    /// </summary>
    [RconId("medkit")] MedKit,
    /// <summary>
    /// Bandage
    /// </summary>
    [RconId("bandage")] Bandage,
    /// <summary>
    /// WW2 Medical Kit
    /// </summary>
    [RconId("ww2medkit")] WW2MedKit,
    /// <summary>
    /// Healing syringe
    /// </summary>
    [RconId("syringe")] Syringe,
    /// <summary>
    /// WW2 Painkiller bottle
    /// </summary>
    [RconId("ww2painkillers")] WW2Painkillers,
    /// <summary>
    /// WW2 Bandage
    /// </summary>
    [RconId("ww2bandage")] WW2Bandage
}