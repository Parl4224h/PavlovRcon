namespace PavlovRcon.Commands;

/// <summary>
/// UgcClearModList command clears the mod list.
/// </summary>
public class UgcClearModList : RconCommand<string>
{
    /// <summary>
    /// Creates a new UgcClearModList command.
    /// </summary>
    public UgcClearModList() : base("UGCClearModList") { }
}