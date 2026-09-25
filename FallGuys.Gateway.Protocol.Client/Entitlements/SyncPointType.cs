using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Entitlements;

[ProtoContract(Name = "FallGuys_Gateway_SyncPointType_V1")]
public enum SyncPointType
{
    [ProtoEnum(Name = "unknown")]
    Unknown,
    [ProtoEnum(Name = "after_login")]
    AfterLogin,
    [ProtoEnum(Name = "after_purchase")]
    AfterPurchase,
    [ProtoEnum(Name = "after_regain_focus")]
    AfterRegainFocus
}
