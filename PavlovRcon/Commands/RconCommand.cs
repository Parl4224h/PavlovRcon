namespace PavlovRcon.Commands;

/// <summary>
/// Base class for RCON commands.
/// </summary>
/// <param name="command">The name of the command</param>
/// <typeparam name="TResponse">The type of the response expected from the command</typeparam>
public abstract class RconCommand<TResponse>(string command)
    : IRconCommand<TResponse>
{
    private readonly string _command = command;
    private readonly List<string> _arguments = [];

    /// <inheritdoc />
    /// <exception cref="InvalidOperationException">Thrown if the number of arguments does not match the expected number</exception>
    public string BuildCommand()
    {
        return string.Join(" ", _command, _arguments);
    }

    /// <summary>
    /// Adds an argument to the command.
    /// </summary>
    /// <param name="value">The value to add for the argument</param>
    protected void Add(string value) => _arguments.Add(value);

    /// <summary>
    /// Adds an argument to the command.
    /// </summary>
    /// <param name="value">The value to add for the argument</param>
    protected void Add(int value) => Add(value.ToString());

    /// <summary>
    /// Adds an argument to the command.
    /// </summary>
    /// <param name="value">The value to add for the argument</param>
    protected void Add(bool value) => Add(value ? "true" : "false");
}