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

    /// <summary>
    /// Adds a mod to the server using its unique identifier.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="uniqueId">The unique identifier of the mod to add.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="AddModResponse"/>.</returns>
    public static Task<AddModResponse> AddMod(
        this IRconClient client,
        string uniqueId,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new AddMod(uniqueId), cancellationToken);

    /// <summary>
    /// Bans a player on the server using their unique ID.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the ban command.</param>
    /// <param name="uniqueId">The unique identifier of the player to be banned.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="BanResponse"/>.</returns>
    public static Task<BanResponse> Ban(
        this IRconClient client,
        string uniqueId,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new Ban(uniqueId), cancellationToken);

    /// <summary>
    /// Requests the current ban list.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the banlist command.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="BanlistResponse"/>.</returns>
    public static Task<BanlistResponse> Banlist(
        this IRconClient client,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new Banlist(), cancellationToken);

    /// <summary>
    /// Clears empty vehicles on the server.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="RconOkResponse"/>.</returns>
    public static Task<RconOkResponse> ClearEmptyVehicles(
        this IRconClient client,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new ClearEmptyVehicles(), cancellationToken);

    /// <summary>
    /// Enables or disables competitive mode.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="enable">Whether to enable competitive mode.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="EnableCompModeResponse"/>.</returns>
    public static Task<EnableCompModeResponse> EnableCompMode(
        this IRconClient client,
        bool enable,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new EnableCompMode(enable), cancellationToken);

    /// <summary>
    /// Enables or disables verbose logging.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="enable">Whether to enable verbose logging.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="EnableVerboseLoggingResponse"/>.</returns>
    public static Task<EnableVerboseLoggingResponse> EnableVerboseLogging(
        this IRconClient client,
        bool enable,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new EnableVerboseLogging(enable), cancellationToken);

    /// <summary>
    /// Enables or disables the whitelist.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="enable">Whether to enable the whitelist.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="EnableWhitelistResponse"/>.</returns>
    public static Task<EnableWhitelistResponse> EnableWhitelist(
        this IRconClient client,
        bool enable,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new EnableWhitelist(enable), cancellationToken);

    /// <summary>
    /// Gags or ungags a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="gag">Whether to gag the player.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GagResponse"/>.</returns>
    public static Task<GagResponse> Gag(
        this IRconClient client,
        string uniqueId,
        bool gag,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new Gag(uniqueId, gag), cancellationToken);

    /// <summary>
    /// Gives all players on a team an item.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="teamId">The target team identifier.</param>
    /// <param name="item">The item to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        string item,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, item), cancellationToken);

    /// <summary>
    /// Grants all players on the specified team a given type of ammunition.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the ammunition.</param>
    /// <param name="ammo">The type of ammunition to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        Ammo ammo,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, ammo), cancellationToken);
    
    /// <summary>
    /// Grants all players on the specified team a given type of attachment.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the attachment.</param>
    /// <param name="attachment">The type of attachment to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        Attachment attachment,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, attachment), cancellationToken);

    /// <summary>
    /// Grants all players on the specified team a given grenade.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the grenade.</param>
    /// <param name="grenade">The grenade to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        Grenade grenade,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, grenade), cancellationToken);

    /// <summary>
    /// Grants all players on the specified team a given heavy.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the heavy.</param>
    /// <param name="heavy">The heavy to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        Heavy heavy,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, heavy), cancellationToken);

    /// <summary>
    /// Grants all players on the specified team a given hide item.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the hide item.</param>
    /// <param name="item">The hide item to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        HideItem item,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, item), cancellationToken);

    /// <summary>
    /// Grants all players on the specified team a given medical item.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the medical item.</param>
    /// <param name="medicalItem">The medical item to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        MedicalItem medicalItem,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, medicalItem), cancellationToken);

    /// <summary>
    /// Grants all players on the specified team a given misc item.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the misc item.</param>
    /// <param name="item">The misc item to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        MiscItem item,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, item), cancellationToken);

    /// <summary>
    /// Grants all players on the specified team a given pistol.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the pistol.</param>
    /// <param name="pistol">The pistol to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        Pistol pistol,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, pistol), cancellationToken);

    /// <summary>
    /// Grants all players on the specified team a given push item.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the push item.</param>
    /// <param name="item">The push item to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        PushItem item,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, item), cancellationToken);

    /// <summary>
    /// Grants all players on the specified team a given rifle.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the rifle.</param>
    /// <param name="rifle">The rifle to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        Rifle rifle,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, rifle), cancellationToken);

    /// <summary>
    /// Grants all players on the specified team a given rocket launcher.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the rocket launcher.</param>
    /// <param name="rocketLauncher">The rocket launcher to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        RocketLauncher rocketLauncher,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, rocketLauncher), cancellationToken);

    /// <summary>
    /// Grants all players on the specified team a given smg.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the smg.</param>
    /// <param name="smg">The smg to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        Smg smg,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, smg), cancellationToken);

    /// <summary>
    /// Grants all players on the specified team a given sniper.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the sniper.</param>
    /// <param name="sniper">The sniper to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        Sniper sniper,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, sniper), cancellationToken);

    /// <summary>
    /// Grants all players on the specified team a given TTT item.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the TTT item.</param>
    /// <param name="item">The TTT item to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        TttItem item,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, item), cancellationToken);

    /// <summary>
    /// Grants all players on the specified team a given vehicle.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="teamId">The identifier of the team receiving the vehicle.</param>
    /// <param name="vehicle">The vehicle to provide.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveAllResponse"/>.</returns>
    public static Task<GiveAllResponse> GiveAll(
        this IRconClient client,
        string teamId,
        Vehicle vehicle,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveAll(teamId, vehicle), cancellationToken);

    /// <summary>
    /// Gives cash to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="amount">The amount of cash to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveCashResponse"/>.</returns>
    public static Task<GiveCashResponse> GiveCash(
        this IRconClient client,
        string uniqueId,
        int amount,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveCash(uniqueId, amount), cancellationToken);

    /// <summary>
    /// Gives a specific item to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="item">The item to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        string item,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, item), cancellationToken);

    /// <summary>
    /// Gives a specific ammo type to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="ammo">The ammo type to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        Ammo ammo,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, ammo), cancellationToken);

    /// <summary>
    /// Gives a specific attachment to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="attachment">The attachment to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        Attachment attachment,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, attachment), cancellationToken);

    /// <summary>
    /// Gives a specific grenade to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="grenade">The grenade to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        Grenade grenade,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, grenade), cancellationToken);

    /// <summary>
    /// Gives a specific heavy to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="heavy">The heavy to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        Heavy heavy,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, heavy), cancellationToken);

    /// <summary>
    /// Gives a specific hide item to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="item">The hide item to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        HideItem item,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, item), cancellationToken);

    /// <summary>
    /// Gives a specific medical item to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="medicalItem">The medical item to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        MedicalItem medicalItem,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, medicalItem), cancellationToken);

    /// <summary>
    /// Gives a specific misc item to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="item">The misc item to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        MiscItem item,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, item), cancellationToken);

    /// <summary>
    /// Gives a specific pistol to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="pistol">The pistol to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        Pistol pistol,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, pistol), cancellationToken);

    /// <summary>
    /// Gives a specific push item to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="item">The push item to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        PushItem item,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, item), cancellationToken);

    /// <summary>
    /// Gives a specific rifle to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="rifle">The rifle to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        Rifle rifle,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, rifle), cancellationToken);

    /// <summary>
    /// Gives a specific rocket launcher to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="rocketLauncher">The rocket launcher to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        RocketLauncher rocketLauncher,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, rocketLauncher), cancellationToken);

    /// <summary>
    /// Gives a specific smg to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="smg">The smg to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        Smg smg,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, smg), cancellationToken);

    /// <summary>
    /// Gives a specific sniper to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="sniper">The sniper to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        Sniper sniper,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, sniper), cancellationToken);

    /// <summary>
    /// Gives a specific TTT item to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="item">The TTT item to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        TttItem item,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, item), cancellationToken);

    /// <summary>
    /// Gives a specific vehicle to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="vehicle">The vehicle to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveItemResponse"/>.</returns>
    public static Task<GiveItemResponse> GiveItem(
        this IRconClient client,
        string uniqueId,
        Vehicle vehicle,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveItem(uniqueId, vehicle), cancellationToken);

    /// <summary>
    /// Gives cash to a team.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="teamId">The target team identifier.</param>
    /// <param name="amount">The amount of cash to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="GiveTeamCashResponse"/>.</returns>
    public static Task<GiveTeamCashResponse> GiveTeamCash(
        this IRconClient client,
        string teamId,
        int amount,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new GiveTeamCash(teamId, amount), cancellationToken);

    /// <summary>
    /// Inspects all connected players.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="InspectAllResponse"/>.</returns>
    public static Task<InspectAllResponse> InspectAll(
        this IRconClient client,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new InspectAll(), cancellationToken);

    /// <summary>
    /// Inspects a specific player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="InspectPlayerResponse"/>.</returns>
    public static Task<InspectPlayerResponse> InspectPlayer(
        this IRconClient client,
        string uniqueId,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new InspectPlayer(uniqueId), cancellationToken);

    /// <summary>
    /// Inspects a specific team.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="teamId">The team identifier to inspect.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="InspectTeamResponse"/>.</returns>
    public static Task<InspectTeamResponse> InspectTeam(
        this IRconClient client,
        string teamId,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new InspectTeam(teamId), cancellationToken);

    /// <summary>
    /// Requests the server item list.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="ItemListResponse"/>.</returns>
    public static Task<ItemListResponse> ItemList(
        this IRconClient client,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new ItemList(), cancellationToken);

    /// <summary>
    /// Kicks a player from the server.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="KickResponse"/>.</returns>
    public static Task<KickResponse> Kick(
        this IRconClient client,
        string uniqueId,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new Kick(uniqueId), cancellationToken);

    /// <summary>
    /// Kills a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="KillResponse"/>.</returns>
    public static Task<KillResponse> Kill(
        this IRconClient client,
        string uniqueId,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new Kill(uniqueId), cancellationToken);

    /// <summary>
    /// Requests the map list.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="MapListResponse"/>.</returns>
    public static Task<MapListResponse> MapList(
        this IRconClient client,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new MapList(), cancellationToken);

    /// <summary>
    /// Requests the moderator list.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="ModeratorListResponse"/>.</returns>
    public static Task<ModeratorListResponse> ModeratorList(
        this IRconClient client,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new ModeratorList(), cancellationToken);

    /// <summary>
    /// Pauses the match for the given duration.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="seconds">The duration to pause in seconds.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="PauseMatchResponse"/>.</returns>
    public static Task<PauseMatchResponse> PauseMatch(
        this IRconClient client,
        int? seconds,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new PauseMatch(seconds), cancellationToken);

    /// <summary>
    /// Requests the refresh list.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="RefreshListResponse"/>.</returns>
    public static Task<RefreshListResponse> RefreshList(
        this IRconClient client,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new RefreshList(), cancellationToken);

    /// <summary>
    /// Removes a map rotation entry from the server.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="map">The name of the map to remove from the rotation.</param>
    /// <param name="gameMode">The game mode for the map rotation entry.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="RconOkResponse"/></returns>
    public static Task<RconOkResponse> RemoveMapRotation(
        this IRconClient client,
        string map,
        GameMode gameMode,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new RemoveMapRotation(map, gameMode), cancellationToken);

    /// <summary>
    /// Removes a mod from the server using its unique identifier.
    /// </summary>
    /// <param name="client">The RconClient instance to use for sending the command.</param>
    /// <param name="uniqueId">The unique identifier of the mod to remove.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="RemoveModResponse"/>.</returns>
    public static Task<RemoveModResponse> RemoveMod(
        this IRconClient client,
        string uniqueId,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new RemoveMod(uniqueId), cancellationToken);

    /// <summary>
    /// Resets the sound settings on the server.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="ResetSndResponse"/>.</returns>
    public static Task<ResetSndResponse> ResetSnd(
        this IRconClient client,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new ResetSnd(), cancellationToken);

    /// <summary>
    /// Rotates to the next map.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="RotateMapResponse"/>.</returns>
    public static Task<RotateMapResponse> RotateMap(
        this IRconClient client,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new RotateMap(), cancellationToken);

    /// <summary>
    /// Requests server info.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="ServerInfoResponse"/>.</returns>
    public static Task<ServerInfoResponse> ServerInfo(
        this IRconClient client,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new ServerInfo(), cancellationToken);

    /// <summary>
    /// Sets the balance table URL.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="url">The URL for the balance table.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="SetBalanceTableUrlResponse"/>.</returns>
    public static Task<SetBalanceTableUrlResponse> SetBalanceTableUrl(
        this IRconClient client,
        string url,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new SetBalanceTableUrl(url), cancellationToken);

    /// <summary>
    /// Sets cash for a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="amount">The cash amount to set.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="SetCashResponse"/>.</returns>
    public static Task<SetCashResponse> SetCash(
        this IRconClient client,
        string uniqueId,
        int amount,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new SetCash(uniqueId, amount), cancellationToken);

    /// <summary>
    /// Sets the limited ammo type.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="ammoType">The ammo type to limit.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="SetLimitedAmmoTypeResponse"/>.</returns>
    public static Task<SetLimitedAmmoTypeResponse> SetLimitedAmmoType(
        this IRconClient client,
        AmmoType ammoType,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new SetLimitedAmmoType(ammoType), cancellationToken);

    /// <summary>
    /// Sets the max players for the server.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="maxPlayers">The maximum players to allow.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="SetMaxPlayersResponse"/>.</returns>
    public static Task<SetMaxPlayersResponse> SetMaxPlayers(
        this IRconClient client,
        int maxPlayers,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new SetMaxPlayers(maxPlayers), cancellationToken);

    /// <summary>
    /// Sets or clears the server PIN.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="pin">The PIN to set or null to clear.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="RconOkResponse"/>.</returns>
    public static Task<RconOkResponse> SetPin(
        this IRconClient client,
        int? pin,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new SetPin(pin), cancellationToken);

    /// <summary>
    /// Sets a player's skin.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="skinId">The skin identifier to set.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="SetPlayerSkinResponse"/>.</returns>
    public static Task<SetPlayerSkinResponse> SetPlayerSkin(
        this IRconClient client,
        string uniqueId,
        int skinId,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new SetPlayerSkin(uniqueId, skinId), cancellationToken);

    /// <summary>
    /// Sets the time limit for the server.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="seconds">The time limit in seconds.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="SetTimeLimitResponse"/>.</returns>
    public static Task<SetTimeLimitResponse> SetTimeLimit(
        this IRconClient client,
        int seconds,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new SetTimeLimit(seconds), cancellationToken);

    /// <summary>
    /// Shows or hides nametags.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="show">Whether to show nametags.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="ShowNametagsResponse"/>.</returns>
    public static Task<ShowNametagsResponse> ShowNametags(
        this IRconClient client,
        bool show,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new ShowNametags(show), cancellationToken);

    /// <summary>
    /// Shuts down the server.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="RconOkResponse"/>.</returns>
    public static Task<RconOkResponse> ShutdownServer(
        this IRconClient client,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new ShutdownServer(), cancellationToken);

    /// <summary>
    /// Slaps a player for a given amount.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="amount">The slap amount.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="SlapResponse"/>.</returns>
    public static Task<SlapResponse> Slap(
        this IRconClient client,
        string uniqueId,
        int amount,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new Slap(uniqueId, amount), cancellationToken);

    /// <summary>
    /// Switches the server to a new map.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="map">The map name to switch to.</param>
    /// <param name="gameMode">The game mode to use.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="SwitchMapResponse"/>.</returns>
    public static Task<SwitchMapResponse> SwitchMap(
        this IRconClient client,
        string map,
        GameMode? gameMode,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new SwitchMap(map, gameMode), cancellationToken);

    /// <summary>
    /// Switches a player to a target team.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="targetTeamId">The target team identifier.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="SwitchTeamResponse"/>.</returns>
    public static Task<SwitchTeamResponse> SwitchTeam(
        this IRconClient client,
        string uniqueId,
        string targetTeamId,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new SwitchTeam(uniqueId, targetTeamId), cancellationToken);

    /// <summary>
    /// Teleports one player to another.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="sourceUniqueId">The source player's unique identifier.</param>
    /// <param name="targetUniqueId">The target player's unique identifier.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="TeleportResponse"/>.</returns>
    public static Task<TeleportResponse> Teleport(
        this IRconClient client,
        string sourceUniqueId,
        string targetUniqueId,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new Teleport(sourceUniqueId, targetUniqueId), cancellationToken);

    /// <summary>
    /// Enables or disables always-on skin menu for TTT.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="enable">Whether to enable the skin menu.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="TttAlwaysEnableSkinMenuResponse"/>.</returns>
    public static Task<TttAlwaysEnableSkinMenuResponse> TttAlwaysEnableSkinMenu(
        this IRconClient client,
        bool enable,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new TttAlwaysEnableSkinMenu(enable), cancellationToken);

    /// <summary>
    /// Ends the current TTT round.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="teamId">The team that wins the round.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="RconOkResponse"/>.</returns>
    public static Task<RconOkResponse> TttEndRound(
        this IRconClient client,
        string teamId,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new TttEndRound(teamId), cancellationToken);

    /// <summary>
    /// Flushes TTT karma.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="TttFlushKarmaResponse"/>.</returns>
    public static Task<TttFlushKarmaResponse> TttFlushKarma(
        this IRconClient client,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new TttFlushKarma(), cancellationToken);

    /// <summary>
    /// Gives TTT credits to a player.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="amount">The amount of credits to give.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="TttGiveCreditsResponse"/>.</returns>
    public static Task<TttGiveCreditsResponse> TttGiveCredits(
        this IRconClient client,
        string uniqueId,
        int amount,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new TttGiveCredits(uniqueId, amount), cancellationToken);

    /// <summary>
    /// Pauses or unpauses the TTT timer.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="pause">Whether to pause the timer.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="TttPauseTimerResponse"/>.</returns>
    public static Task<TttPauseTimerResponse> TttPauseTimer(
        this IRconClient client,
        bool pause,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new TttPauseTimer(pause), cancellationToken);

    /// <summary>
    /// Sets a player's TTT karma.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="amount">The karma amount to set.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="TttSetKarmaResponse"/>.</returns>
    public static Task<TttSetKarmaResponse> TttSetKarma(
        this IRconClient client,
        string uniqueId,
        int amount,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new TttSetKarma(uniqueId, amount), cancellationToken);

    /// <summary>
    /// Sets a player's TTT role.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The player's unique identifier.</param>
    /// <param name="tttRole">The TTT role to set.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="TttSetRoleResponse"/>.</returns>
    public static Task<TttSetRoleResponse> TttSetRole(
        this IRconClient client,
        string uniqueId,
        TttRole tttRole,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new TttSetRole(uniqueId, tttRole), cancellationToken);

    /// <summary>
    /// Adds a UGC mod by ID.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="ugcId">The UGC identifier.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="UgcModResponse"/>.</returns>
    public static Task<UgcModResponse> UgcAddMod(
        this IRconClient client,
        string ugcId,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new UgcAddMod(ugcId), cancellationToken);

    /// <summary>
    /// Clears the UGC mod list.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="RconOkResponse"/>.</returns>
    public static Task<RconOkResponse> UgcClearModList(
        this IRconClient client,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new UgcClearModList(), cancellationToken);

    /// <summary>
    /// Requests the UGC mod list.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="UgcModListResponse"/>.</returns>
    public static Task<UgcModListResponse> UgcModList(
        this IRconClient client,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new UgcModList(), cancellationToken);

    /// <summary>
    /// Removes a UGC mod by ID.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="ugcId">The UGC identifier.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="UgcModResponse"/>.</returns>
    public static Task<UgcModResponse> UgcRemoveMod(
        this IRconClient client,
        string ugcId,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new UgcRemoveMod(ugcId), cancellationToken);

    /// <summary>
    /// Unbans a player using their unique ID.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="uniqueId">The unique identifier of the player to unban.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="UnbanResponse"/>.</returns>
    public static Task<UnbanResponse> Unban(
        this IRconClient client,
        string uniqueId,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new Unban(uniqueId), cancellationToken);

    /// <summary>
    /// Updates the server name.
    /// </summary>
    /// <param name="client">The RconClient instance used to send the command.</param>
    /// <param name="serverName">The new server name.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <returns>The result of the operation as a <see cref="UpdateServerNameResponse"/>.</returns>
    public static Task<UpdateServerNameResponse> UpdateServerName(
        this IRconClient client,
        string serverName,
        CancellationToken cancellationToken = default
    ) => client.SendCommandAsync(new UpdateServerName(serverName), cancellationToken);
}
