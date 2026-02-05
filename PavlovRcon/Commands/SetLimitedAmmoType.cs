using PavlovRcon.GameData;
using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// SetLimitedAmmoType command sets the limited ammo type.
/// </summary>
public class SetLimitedAmmoType : RconCommand<SetLimitedAmmoTypeResponse>
{
    /// <summary>
    /// Creates a new SetLimitedAmmoType command.
    /// </summary>
    /// <param name="ammoType">The ammo type to set.</param>
    public SetLimitedAmmoType(AmmoType ammoType) : base("SetLimitedAmmoType")
    {
        Add(ammoType.ToRconId());
    }
}