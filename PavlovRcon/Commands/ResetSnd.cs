namespace PavlovRcon.Commands;

/// <summary>
/// ResetSnd command, resets the game on the Search and Destroy game mode.
/// </summary>
public class ResetSnd : RconCommand<string>
{
    /// <summary>
    /// Creates a new ResetSnd command.
    /// </summary>
    public ResetSnd() : base("ResetSND") { }
}