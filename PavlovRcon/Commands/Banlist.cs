using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     BanList command retrieves the current banlist.
/// </summary>
public class Banlist : RconCommand<BanlistResponse>
{
    /// <summary>
    ///     Creates a new Banlist command.
    /// </summary>
    public Banlist() : base("Banlist")
    {
    }
}