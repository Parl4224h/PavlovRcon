using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     EnableCompMode command, enables or disables competitive mode.
/// </summary>
public class EnableCompMode : RconCommand<EnableCompModeResponse>
{
    /// <summary>
    ///     Creates a new EnableCompMode command.
    /// </summary>
    /// <param name="enable">Whether to enable competitive mode.</param>
    public EnableCompMode(bool enable) : base("EnableCompMode")
    {
        Add(enable);
    }
}