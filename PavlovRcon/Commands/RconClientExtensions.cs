using PavlovRcon.GameData;
using PavlovRcon.RconClient;
using PavlovRcon.Responses;

namespace PavlovRcon.Commands;

/// <summary>
/// Extension methods for the RconClient. Allowing for direct use of all commands
/// </summary>
public static class RconClientExtensions
{
    /// <summary>
    /// Adds a map rotation entry to the server.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="map">The name of the map to add to the rotation.</param>
    /// <param name="gameMode">The game mode for the map rotation entry.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="RconOkResponse"/></returns>
    public static Task<RconOkResponse> AddMapRotationAsync(
        this IRconClient client,
        string map,
        GameMode gameMode,
        CancellationToken cancellationToken = default
    ) =>
        client.SendCommandAsync(new AddMapRotation(map, gameMode), cancellationToken);
}