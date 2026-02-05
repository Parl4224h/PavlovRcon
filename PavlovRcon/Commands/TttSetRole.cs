using PavlovRcon.GameData;
using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     TttSetRole command sets the role of a player in TTT.
/// </summary>
public class TttSetRole : RconCommand<TttSetRoleResponse>
{
    /// <summary>
    ///     Creates a new TttSetRole command.
    /// </summary>
    /// <param name="uniqueId">The unique identifier of the player.</param>
    /// <param name="tttRole">The role to set for the player.</param>
    public TttSetRole(string uniqueId, TttRole tttRole) : base("TTTSetRole")
    {
        Add(uniqueId);
        Add(tttRole.ToRconId());
    }
}