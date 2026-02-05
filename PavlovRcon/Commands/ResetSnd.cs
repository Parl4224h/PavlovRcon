using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// ResetSnd command, resets the game on the Search and Destroy game mode.
/// </summary>
public class ResetSnd : RconCommand<ResetSndResponse>
{
    /// <summary>
    /// Creates a new ResetSnd command.
    /// </summary>
    public ResetSnd() : base("ResetSND") { }
}