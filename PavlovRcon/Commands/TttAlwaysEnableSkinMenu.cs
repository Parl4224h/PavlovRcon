using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// TTTAlwaysEnableSkinMenu command, enables or disables the always enable skin menu feature.
/// </summary>
public class TttAlwaysEnableSkinMenu : RconCommand<TttAlwaysEnableSkinMenuResponse>
{
    /// <summary>
    /// Creates a new TTTAlwaysEnableSkinMenu command.
    /// </summary>
    /// <param name="enable">Whether to enable or disable the always enable skin menu feature.</param>
    public TttAlwaysEnableSkinMenu(bool enable) : base("TTTAlwaysEnableSkinMenu") => Add(enable);
}