namespace PavlovRcon.Commands;

/// <summary>
/// The UgcAddMod command adds a mod to the server
/// </summary>
public class UgcAddMod : RconCommand<string>
{
    /// <summary>
    /// Creates a new UgcAddMod command.
    /// </summary>
    /// <param name="ugcId">The unique identifier of the mod to add.</param>
    public UgcAddMod(string ugcId) : base("UGCAddMod") => Add(ugcId);
}