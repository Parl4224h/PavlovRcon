namespace PavlovRcon.Commands;

/// <summary>
/// RotateMap command, rotates the map.
/// </summary>
public class RotateMap : RconCommand<string>
{
    /// <summary>
    /// Creates a new RotateMap command.
    /// </summary>
    public RotateMap() : base("RotateMap") { }
}