using PavlovRcon.GameData;

namespace PavlovRcon.Commands;

/// <summary>
/// SetLimitedAmmoType command sets the limited ammo type.
/// </summary>
public class SetLimitedAmmoType : RconCommand<string>
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