using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// SetPin command, sets the pin for the server.
/// </summary>
public class SetPin : RconCommand<RconOkResponse>
{
    /// <summary>
    /// Creates a new SetPin command.
    /// </summary>
    /// <param name="pin">The pin to set, if null the pin will be removed. Must be between 0 and 9999.</param>
    public SetPin(int? pin) : base("SetPin")
    {
        if (pin.HasValue) Add(pin.Value);
    }
}