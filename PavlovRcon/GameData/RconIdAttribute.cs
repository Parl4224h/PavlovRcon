namespace PavlovRcon.GameData;

/// <summary>
///     Attribute to specify the RCON ID for an in game entity
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public sealed class RconIdAttribute : Attribute
{
    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="id">The RCON ID for the entity</param>
    public RconIdAttribute(string id)
    {
        Id = id;
    }

    /// <summary>
    ///     The RCON ID for the entity
    /// </summary>
    public string Id { get; }
}