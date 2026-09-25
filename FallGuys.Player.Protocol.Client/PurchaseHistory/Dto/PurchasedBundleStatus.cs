using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.PurchaseHistory.Dto;

[ProtoContract(Name = "FallGuys_PurchaseHistory_PurchasedBundleStatus_V1")]
public enum PurchasedBundleStatus
{
    [ProtoEnum(Name = "unknown")]
    Unknown,
    [ProtoEnum(Name = "cancellable")]
    Cancellable,
    [ProtoEnum(Name = "returnable")]
    Returnable,
    [ProtoEnum(Name = "returned")]
    Returned,
    [ProtoEnum(Name = "not_eligible")]
    NotEligible
}
