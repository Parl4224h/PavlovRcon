using PavlovRcon.GameData;
using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// GiveAll command gives all players on a team the specified ammo.
/// </summary>
public class GiveAll : RconCommand<GiveAllResponse>
{
    /// <summary>
    /// Creates a new GiveAll command. Allows for custom items.
    /// </summary>
    /// <param name="teamId">The team ID to give ammo to.</param>
    /// <param name="item">The item to give.</param>
    public GiveAll(string teamId, string item) : base("GiveAll")
    {
        Add(teamId);
        Add(item);
    }
    
    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give ammo to.</param>
    /// <param name="ammo">The ammo type to give.</param>
    public GiveAll(string teamId, Ammo ammo) : base("GiveAll")
    {
        Add(teamId);
        Add(ammo.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give an attachment to.</param>
    /// <param name="attachment">The attachment to give.</param>
    public GiveAll(string teamId, Attachment attachment) : base("GiveAll")
    {
        Add(teamId);
        Add(attachment.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give a grenade to.</param>
    /// <param name="grenade">The grenade to give.</param>
    public GiveAll(string teamId, Grenade grenade) : base("GiveAll")
    {
        Add(teamId);
        Add(grenade.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give a heavy to.</param>
    /// <param name="heavy">The heavy to give.</param>
    public GiveAll(string teamId, Heavy heavy) : base("GiveAll")
    {
        Add(teamId);
        Add(heavy.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give a hide item to.</param>
    /// <param name="item">The hide item to give.</param>
    public GiveAll(string teamId, HideItem item) : base("GiveAll")
    {
        Add(teamId);
        Add(item.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give a medical item to.</param>
    /// <param name="medicalItem">The medical item to give.</param>
    public GiveAll(string teamId, MedicalItem medicalItem) : base("GiveAll")
    {
        Add(teamId);
        Add(medicalItem.ToRconId());
    }

    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give a misc item to.</param>
    /// <param name="item">The misc item to give.</param>
    public GiveAll(string teamId, MiscItem item) : base("GiveAll")
    {
        Add(teamId);
        Add(item.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give a pistol to.</param>
    /// <param name="pistol">The pistol to give.</param>
    public GiveAll(string teamId, Pistol pistol) : base("GiveAll")
    {
        Add(teamId);
        Add(pistol.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give a push item to.</param>
    /// <param name="item">The push item to give.</param>
    public GiveAll(string teamId, PushItem item) : base("GiveAll")
    {
        Add(teamId);
        Add(item.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give a rifle to.</param>
    /// <param name="rifle">The rifle to give.</param>
    public GiveAll(string teamId, Rifle rifle) : base("GiveAll")
    {
        Add(teamId);
        Add(rifle.ToRconId());
    }

    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give a rocket launcher to.</param>
    /// <param name="rocketLauncher">The rocket launcher to give.</param>
    public GiveAll(string teamId, RocketLauncher rocketLauncher) : base("GiveAll")
    {
        Add(teamId);
        Add(rocketLauncher.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give a smg to.</param>
    /// <param name="smg">The smg to give.</param>
    public GiveAll(string teamId, Smg smg) : base("GiveAll")
    {
        Add(teamId);
        Add(smg.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give a sniper to.</param>
    /// <param name="sniper">The sniper to give.</param>
    public GiveAll(string teamId, Sniper sniper) : base("GiveAll")
    {
        Add(teamId);
        Add(sniper.ToRconId());
    }
    
    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give a ttt item to.</param>
    /// <param name="item">The ttt item to give.</param>
    public GiveAll(string teamId, TttItem item) : base("GiveAll")
    {
        Add(teamId);
        Add(item.ToRconId());
    }

    /// <summary>
    /// Creates a new GiveAll command.
    /// </summary>
    /// <param name="teamId">The team ID to give a vehicle to.</param>
    /// <param name="vehicle">The vehicle to give.</param>
    public GiveAll(string teamId, Vehicle vehicle) : base("GiveAll")
    {
        Add(teamId);
        Add(vehicle.ToRconId());
    }
}