namespace PavlovRcon.Commands;

/// <summary>
/// UGCModList command retrieves the list of mods on the server.
/// </summary>
public class UgcModList : RconCommand<string>
{
    /// <summary>
    /// Creates a new UgcModList command.
    /// </summary>
    public UgcModList() : base("UGCModList") { }
}