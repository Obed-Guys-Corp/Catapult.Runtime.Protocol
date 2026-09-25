using ProtoBuf;
using System.Collections.Generic;

namespace Catapult.Services.Login.Protocol.Client.Responses;

[ProtoContract(Name = "Catapult_Login_IdentitiesResponse_V1")]
public class IdentitiesResponse
{
    private List<IdentityResponse>? _identities;

    [ProtoMember(1)]
    public List<IdentityResponse> Identities { get; set; }
}
