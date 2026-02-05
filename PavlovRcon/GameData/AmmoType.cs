using System.Text.Json.Serialization;

namespace PavlovRcon.GameData;

[JsonConverter(typeof(RconIdEnumJsonConverter<AmmoType>))]
public enum AmmoType
{
    [RconId("0")]
    Unlimited,
    [RconId("1")]
    LimitedGeneric,
    [RconId("2")]
    LimitedSpecific,
    [RconId("3")]
    Custom,
    [RconId("4")]
    LimitedSpecial,
    [RconId("5")]
    Boxless
}