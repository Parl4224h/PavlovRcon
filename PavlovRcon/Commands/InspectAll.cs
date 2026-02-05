namespace PavlovRcon.Commands;

/// <summary>
/// InspectAll command, inspects all players.
/// </summary>
public class InspectAll : RconCommand<string>
{
    /// <summary>
    /// Creates a new InspectAll command.
    /// </summary>
    public InspectAll() : base("InspectAll")
    {
    }
}