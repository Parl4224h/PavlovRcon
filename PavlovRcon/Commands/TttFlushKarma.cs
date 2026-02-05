using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// TttFlushKarma command, resets the karma of all players to 1200.
/// </summary>
public class TttFlushKarma : RconCommand<TttFlushKarmaResponse>
{
    /// <summary>
    /// Creates a new TttFlushKarma command.
    /// </summary>
    public TttFlushKarma() : base("TTTFlushKarma") { }
}