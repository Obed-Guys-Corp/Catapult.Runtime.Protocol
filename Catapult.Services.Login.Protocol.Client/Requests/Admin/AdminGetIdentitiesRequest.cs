using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Requests.Admin;

[ProtoContract(Name = "Catapult_Login_AdminGetIdentitiesRequest_V1")]
[Authorize(Roles = new string[] { CoreRoles.Admin, CoreRoles.Super })]
public class AdminGetIdentitiesRequest
{
    [ProtoMember(1)]
    public string? AccountId { get; set; }
}
