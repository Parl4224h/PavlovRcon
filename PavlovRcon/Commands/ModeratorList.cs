using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     ModeratorList command, retrieves the current list of moderators.
/// </summary>
public class ModeratorList : RconCommand<ModeratorListResponse>
{
    /// <summary>
    ///     Creates a new ModeratorList command.
    /// </summary>
    public ModeratorList() : base("ModeratorList")
    {
    }
}