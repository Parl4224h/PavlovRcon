namespace PavlovRcon.Commands;

/// <summary>
/// The UgcRemoveMod command removes a mod from the server.
/// </summary>
public class UgcRemoveMod : RconCommand<string>
{
    /// <summary>
    /// Creates a new UgcRemoveMod command.
    /// </summary>
    /// <param name="ugcId">The unique identifier of the mod to remove.</param>
    public UgcRemoveMod(string ugcId) : base("UGCRemoveMod") => Add(ugcId);
}