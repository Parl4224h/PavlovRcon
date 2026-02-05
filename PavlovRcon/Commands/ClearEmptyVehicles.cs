using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     ClearEmptyVehicles command, removes all vehicles not occupied by players.
/// </summary>
public class ClearEmptyVehicles : RconCommand<RconOkResponse>
{
    /// <summary>
    ///     Creates a new ClearEmptyVehicles command.
    /// </summary>
    public ClearEmptyVehicles() : base("ClearEmptyVehicles")
    {
    }
}