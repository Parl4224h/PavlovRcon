namespace PavlovRcon.GameData;

/// <summary>
///     Vehicles.
/// </summary>
public enum Vehicle
{
    /// <summary>
    ///     Panzer Tank
    /// </summary>
    [RconId("panzer")] PanzerTank = 0,

    /// <summary>
    ///     Sherman Tank
    /// </summary>
    [RconId("sherman")] ShermanTank = 1,

    /// <summary>
    ///     T34 Tank
    /// </summary>
    [RconId("t34")] T34Tank = 2,

    /// <summary>
    ///     Tiger Tank
    /// </summary>
    [RconId("tiger")] TigerTank = 3,

    /// <summary>
    ///     ATV
    /// </summary>
    [RconId("atv")] ATV = 4,

    /// <summary>
    ///     Truck
    /// </summary>
    [RconId("truck")] Truck = 5,

    /// <summary>
    ///     WW2 German Car
    /// </summary>
    [RconId("kubel")] WW2GermanCar = 6,

    /// <summary>
    ///     Willys Jeep
    /// </summary>
    [RconId("willys")] WillysJeep = 7,

    /// <summary>
    ///     Willys Soviet Jeep
    /// </summary>
    [RconId("willys_svt")] WillysSovietJeep = 8,

    /// <summary>
    ///     Motorcycle
    /// </summary>
    [RconId("motorcycle")] Motorcycle = 9
}
