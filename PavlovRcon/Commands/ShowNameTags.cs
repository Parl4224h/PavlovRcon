namespace PavlovRcon.Commands;

/// <summary>
/// ShowNameTags command, enables or disables name tags.
/// </summary>
public class ShowNameTags : RconCommand<string>
{
    /// <summary>
    /// Creates a new ShowNameTags command.
    /// </summary>
    /// <param name="show">Whether to show name tags.</param>
    public ShowNameTags(bool show) : base("ShowNameTags") => Add(show);
}