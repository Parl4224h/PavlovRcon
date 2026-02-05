namespace PavlovRcon.Commands;

/// <summary>
/// The RemoveMod command removes a mod from the server.
/// </summary>
public class RemoveMod : RconCommand<string>
{
    /// <summary>
    /// Creates a new RemoveMod command.
    /// </summary>
    /// <param name="uniqueId">The unique identifier of the mod to remove.</param>
    public RemoveMod(string uniqueId) : base("RemoveMod") => Add(uniqueId);
}