using ProtoBuf;

namespace Catapult.Protocol.Internal;

[ProtoContract(Name = "AuthHeader_V1")]
public class AuthHeader : MessageHeader
{
    [ProtoMember(1)]
    public string? Token { get; set; }

    public AuthHeader(string? token)
    {
        Token = token;
    }

    public AuthHeader()
    {
    }
}
