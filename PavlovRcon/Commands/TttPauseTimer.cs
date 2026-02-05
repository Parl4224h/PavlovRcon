namespace PavlovRcon.Commands;

/// <summary>
/// TttPauseTimer command, pauses or unpauses the timer.
/// </summary>
public class TttPauseTimer : RconCommand<string>
{
    /// <summary>
    /// Creates a new TttPauseTimer command.
    /// </summary>
    /// <param name="pause">Whether to pause or unpause the timer.</param>
    public TttPauseTimer(bool pause) : base("TTTPauseTimer") => Add(pause);
}