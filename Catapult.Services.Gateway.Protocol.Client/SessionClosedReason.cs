using ProtoBuf;

namespace Catapult.Services.Gateway.Protocol.Client;

[ProtoContract(Name = "Catapult_Gateway_SessionClosedReason_V1")]
public enum SessionClosedReason
{
    [ProtoEnum(Name = "unknown")]
    Unknown,
    [ProtoEnum(Name = "anotherdeviceconnected")]
    AnotherDeviceConnected
}
