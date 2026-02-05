namespace PavlovRcon.Commands;

/// <summary>
/// RefreshList command, retrieves a list of all connected players and information about them.
/// </summary>
public class RefreshList : RconCommand<string>
{
    /// <summary>
    /// Creates a new RefreshList command.
    /// </summary>
    public RefreshList() : base("RefreshList") { }
}