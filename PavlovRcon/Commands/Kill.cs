using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     Kill command, kills a player.
/// </summary>
public class Kill : RconCommand<KillResponse>
{
    /// <summary>
    ///     Creates a new Kill command.
    /// </summary>
    /// <param name="uniqueId">The unique id to kill.</param>
    public Kill(string uniqueId) : base("Kill")
    {
        Add(uniqueId);
    }
}