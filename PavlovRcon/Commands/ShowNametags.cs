using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
///     ShowNametags command, enables or disables nametags.
/// </summary>
public class ShowNametags : RconCommand<ShowNametagsResponse>
{
    /// <summary>
    ///     Creates a new ShowNametags command.
    /// </summary>
    /// <param name="show">Whether to show nametags.</param>
    public ShowNametags(bool show) : base("ShowNametags")
    {
        Add(show);
    }
}