using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Debug;

[ProtoContract(Name = "FallGuys_Gateway_GenerateDebugStringResponse_V1")]
public class GenerateDebugStringResponse
{
    [ProtoMember(1)]
    public string Data { get; set; }
}
