using ProtoBuf;
using System.Collections.Generic;

namespace Catapult.Services.Login.Protocol.Client.Responses;

[ProtoContract(Name = "Catapult_Login_IdentitiesResponse_V1")]
public class IdentitiesResponse
{
    [ProtoMember(1)]
    public List<IdentityResponse> Identities { get; set; } = null!;
}
