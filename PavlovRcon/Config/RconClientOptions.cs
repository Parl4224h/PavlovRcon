namespace PavlovRcon.Config;

/// <summary>
///     Options for the RconClient
/// </summary>
public sealed class RconClientOptions
{
    /// <summary>
    ///     Whether the client should automatically connect to the server when a command is sent and the server is not
    ///     connected. Default is true.
    /// </summary>
    public bool AutoConnect { get; init; } = true;

    /// <summary>
    ///     The amount of time to wait before disconnecting the client if it has not sent a command. Default is 1 hour.
    /// </summary>
    public TimeSpan IdleDisconnectTimeout { get; init; } = TimeSpan.FromHours(1);

    /// <summary>
    ///     The interval at which the client will check if it is idle. Default is 3 minutes.
    /// </summary>
    public TimeSpan IdleCheckInterval { get; init; } = TimeSpan.FromMinutes(3);

    /// <summary>
    ///     The default timeout for commands. Default is 5 seconds.
    /// </summary>
    public TimeSpan CommandTimeout { get; init; } = TimeSpan.FromSeconds(5);
}