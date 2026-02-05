using PavlovRcon.GameData;

namespace PavlovRcon.Commands;

/// <summary>
/// GiveItem command, gives a player an item.
/// </summary>
public class GiveItem : RconCommand<string>
{
    /// <summary>
    /// Creates a new GiveItem command. Allows for custom items.
    /// </summary>
    /// <param name="uniqueId">The unique id to give an item to.</param>
    /// <param name="item">The item to give.</param>
    public GiveItem(string uniqueId, string item) : base("GiveItem")
    {
        Add(uniqueId);
        Add(item);
    }
    
    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give ammo to.</param>
    /// <param name="ammo">The ammo type to give.</param>
    public GiveItem(string uniqueId, Ammo ammo) : base("GiveItem")
    {
        Add(uniqueId);
        Add(ammo.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give an attachment to.</param>
    /// <param name="attachment">The attachment to give.</param>
    public GiveItem(string uniqueId, Attachment attachment) : base("GiveItem")
    {
        Add(uniqueId);
        Add(attachment.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give a grenade to.</param>
    /// <param name="grenade">The grenade to give.</param>
    public GiveItem(string uniqueId, Grenade grenade) : base("GiveItem")
    {
        Add(uniqueId);
        Add(grenade.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give a heavy to.</param>
    /// <param name="heavy">The heavy to give.</param>
    public GiveItem(string uniqueId, Heavy heavy) : base("GiveItem")
    {
        Add(uniqueId);
        Add(heavy.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give a hide item to.</param>
    /// <param name="item">The hide item to give.</param>
    public GiveItem(string uniqueId, HideItem item) : base("GiveItem")
    {
        Add(uniqueId);
        Add(item.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give a medical item to.</param>
    /// <param name="medicalItem">The medical item to give.</param>
    public GiveItem(string uniqueId, MedicalItem medicalItem) : base("GiveItem")
    {
        Add(uniqueId);
        Add(medicalItem.ToRconId());
    }

    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give a misc item to.</param>
    /// <param name="item">The misc item to give.</param>
    public GiveItem(string uniqueId, MiscItem item) : base("GiveItem")
    {
        Add(uniqueId);
        Add(item.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give a pistol to.</param>
    /// <param name="pistol">The pistol to give.</param>
    public GiveItem(string uniqueId, Pistol pistol) : base("GiveItem")
    {
        Add(uniqueId);
        Add(pistol.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give a push item to.</param>
    /// <param name="item">The push item to give.</param>
    public GiveItem(string uniqueId, PushItem item) : base("GiveItem")
    {
        Add(uniqueId);
        Add(item.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give a rifle to.</param>
    /// <param name="rifle">The rifle to give.</param>
    public GiveItem(string uniqueId, Rifle rifle) : base("GiveItem")
    {
        Add(uniqueId);
        Add(rifle.ToRconId());
    }

    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give a rocket launcher to.</param>
    /// <param name="rocketLauncher">The rocket launcher to give.</param>
    public GiveItem(string uniqueId, RocketLauncher rocketLauncher) : base("GiveItem")
    {
        Add(uniqueId);
        Add(rocketLauncher.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give a smg to.</param>
    /// <param name="smg">The smg to give.</param>
    public GiveItem(string uniqueId, Smg smg) : base("GiveItem")
    {
        Add(uniqueId);
        Add(smg.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give a sniper to.</param>
    /// <param name="sniper">The sniper to give.</param>
    public GiveItem(string uniqueId, Sniper sniper) : base("GiveItem")
    {
        Add(uniqueId);
        Add(sniper.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give a ttt item to.</param>
    /// <param name="item">The ttt item to give.</param>
    public GiveItem(string uniqueId, TttItem item) : base("GiveItem")
    {
        Add(uniqueId);
        Add(item.ToRconId());
    }

    /// <summary>
    /// Creates a new GiveItem command.
    /// </summary>
    /// <param name="uniqueId">The unique id to give a vehicle to.</param>
    /// <param name="vehicle">The vehicle to give.</param>
    public GiveItem(string uniqueId, Vehicle vehicle) : base("GiveItem")
    {
        Add(uniqueId);
        Add(vehicle.ToRconId());
    }
}