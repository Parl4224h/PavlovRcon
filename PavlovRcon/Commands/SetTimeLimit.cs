namespace PavlovRcon.Commands;

/// <summary>
/// SetTimeLimit command, sets the time limit.
/// </summary>
public class SetTimeLimit : RconCommand<string>
{
    /// <summary>
    /// Create a new SetTimeLimit command.
    /// </summary>
    /// <param name="seconds">The time limit in seconds</param>
    public SetTimeLimit(int seconds) : base("SetTimeLimit") => Add(seconds);
}