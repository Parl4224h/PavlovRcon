namespace PavlovRcon.GameData;

/// <summary>
///     Vehicles.
/// </summary>
public enum Vehicle
{
    /// <summary>
    ///     Panzer Tank
    /// </summary>
    [RconId("panzer")] PanzerTank,

    /// <summary>
    ///     Sherman Tank
    /// </summary>
    [RconId("sherman")] ShermanTank,

    /// <summary>
    ///     T34 Tank
    /// </summary>
    [RconId("t34")] T34Tank,

    /// <summary>
    ///     Tiger Tank
    /// </summary>
    [RconId("tiger")] TigerTank,

    /// <summary>
    ///     ATV
    /// </summary>
    [RconId("atv")] ATV,

    /// <summary>
    ///     Truck
    /// </summary>
    [RconId("truck")] Truck,

    /// <summary>
    ///     WW2 German Car
    /// </summary>
    [RconId("kubel")] WW2GermanCar,

    /// <summary>
    ///     Willys Jeep
    /// </summary>
    [RconId("willys")] WillysJeep,

    /// <summary>
    ///     Willys Soviet Jeep
    /// </summary>
    [RconId("willys_svt")] WillysSovietJeep,

    /// <summary>
    ///     Motorcycle
    /// </summary>
    [RconId("motorcycle")] Motorcycle
}