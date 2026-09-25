using ProtoBuf;

namespace Catapult.Services.Gateway.Protocol.Client;

[ProtoContract(Name = "Catapult_Gateway_AuthenticationResponse_V1")]
public class AuthenticationResponse
{
    [ProtoMember(1)]
    public string? UserId { get; set; }
}
