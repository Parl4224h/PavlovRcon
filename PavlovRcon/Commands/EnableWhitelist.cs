using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     EnableWhitelist command, enables or disables the whitelist.
/// </summary>
public class EnableWhitelist : RconCommand<EnableWhitelistResponse>
{
    /// <summary>
    ///     Creates a new EnableWhitelist command.
    /// </summary>
    /// <param name="enable">Whether to enable the whitelist.</param>
    public EnableWhitelist(bool enable) : base("EnableWhitelist")
    {
        Add(enable);
    }
}