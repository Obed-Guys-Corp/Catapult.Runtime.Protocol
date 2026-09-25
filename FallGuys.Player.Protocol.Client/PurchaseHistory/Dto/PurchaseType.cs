using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.PurchaseHistory.Dto;

[ProtoContract(Name = "FallGuys_PurchaseHistory_PurchaseType_V1")]
public enum PurchaseType
{
    [ProtoEnum(Name = "unknown")]
    Unknown,
    [ProtoEnum(Name = "itemPayment")]
    ItemPayment
}
