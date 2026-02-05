namespace PavlovRcon.Config;

/// <summary>
///     Connection information for a RCON server.
/// </summary>
/// <param name="Host">The IP address of the RCON server.</param>
/// <param name="Port">The port number to connect to on the RCON server.</param>
/// <param name="Password">The password required to authenticate with the RCON server.</param>
public record RconConnectionInfo(string Host, int Port, string Password);