namespace PavlovRcon.Commands;

/// <summary>
/// Contract for RCON commands.
/// </summary>
/// <typeparam name="TResponse"></typeparam>
public interface IRconCommand<TResponse>
{
    /// <summary>
    /// Builds the command string.
    /// </summary>
    /// <returns>The command string to be sent over RCON</returns>
    public string BuildCommand();
}