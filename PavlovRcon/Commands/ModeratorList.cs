namespace PavlovRcon.Commands;

/// <summary>
/// ModeratorList command, retrieves the current list of moderators.
/// </summary>
public class ModeratorList : RconCommand<string>
{
    /// <summary>
    /// Creates a new ModeratorList command.
    /// </summary>
    public ModeratorList() : base("ModeratorList") { }
}