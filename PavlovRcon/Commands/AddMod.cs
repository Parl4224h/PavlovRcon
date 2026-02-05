using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     The AddMod command.
/// </summary>
public class AddMod : RconCommand<AddModResponse>
{
    /// <summary>
    ///     Creates a new AddMod command.
    /// </summary>
    /// <param name="uniqueId">The unique identifier of the mod to add.</param>
    public AddMod(string uniqueId) : base("AddMod")
    {
        Add(uniqueId);
    }
}