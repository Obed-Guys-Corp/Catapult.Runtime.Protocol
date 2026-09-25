using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Responses;

[ProtoContract(Name = "Catapult_Login_LookupIdentityResponse_V1")]
public class LookupAccountResponse
{
    [ProtoMember(1)]
    public string? AccountId { get; set; }

    [ProtoMember(2)]
    public string? SupportId { get; set; }
}
