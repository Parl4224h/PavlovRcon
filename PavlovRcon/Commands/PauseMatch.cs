using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     PauseMatch command, pauses the match for a specified amount of time.
/// </summary>
public class PauseMatch : RconCommand<PauseMatchResponse>
{
    /// <summary>
    ///     Creates a new PauseMatch command.
    /// </summary>
    /// <param name="seconds">The number of seconds to pause the match for, if omitted 15 seconds is the default</param>
    public PauseMatch(int? seconds) : base("PauseMatch")
    {
        if (seconds.HasValue) Add(seconds.Value);
    }
}