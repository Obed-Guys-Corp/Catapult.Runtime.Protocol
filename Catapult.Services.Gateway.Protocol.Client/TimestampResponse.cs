using ProtoBuf;
using System;

namespace Catapult.Services.Gateway.Protocol.Client;

[ProtoContract(Name = "Catapult_Gateway_TimestampResponse_V1")]
public class TimestampResponse
{
    [ProtoMember(1)]
    public DateTime Utc { get; set; }
}
