namespace PavlovRcon.GameData;

public enum Vehicle
{
    [RconId("panzer")] PanzerTank,
    [RconId("sherman")] ShermanTank,
    [RconId("t34")] T34Tank,
    [RconId("tiger")] TigerTank,
    [RconId("atv")] ATV,
    [RconId("truck")] Truck,
    [RconId("kubel")] WW2GermanCar,
    [RconId("willys")] WillysJeep,
    [RconId("willys_svt")] WillysSovietJeep,
    [RconId("motorcycle")] Motorcycle
}