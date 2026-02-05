using System.Text.Json.Serialization;
using PavlovRcon.GameData;

namespace PavlovRcon.Responses;

/// <summary>
///     Response for the SetLimitedAmmoType command.
/// </summary>
public class SetLimitedAmmoTypeResponse : RconResponseBase
{
    /// <summary>
    ///     The new limited ammo type.
    /// </summary>
    [JsonPropertyName("LimitedAmmoType")]
    public AmmoType LimitedAmmoType { get; set; }

    /// <summary>
    ///     Whether the command was successful.
    /// </summary>
    [JsonPropertyName("SetLimitedAmmoType")]
    public bool SetLimitedAmmoType { get; set; }

    /// <inheritdoc />
    protected override bool EvaluateSuccess()
    {
        return SetLimitedAmmoType;
    }
}