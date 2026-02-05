namespace PavlovRcon.Commands;

/// <summary>
/// EnableVerboseLogging command, enables or disables verbose logging.
/// </summary>
public class EnableVerboseLogging : RconCommand<string>
{
    /// <summary>
    /// Creates a new EnableVerboseLogging command.
    /// </summary>
    /// <param name="enable">Whether to enable verbose logging.</param>
    public EnableVerboseLogging(bool enable) : base("EnableVerboseLogging") => Add(enable);
}