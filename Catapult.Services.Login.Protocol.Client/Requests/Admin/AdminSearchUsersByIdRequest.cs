using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Requests.Admin;

[Authorize(Roles = new string[] { CoreRoles.Admin, CoreRoles.Super })]
[ProtoContract(Name = "Catapult_Login_AdminGetAccountsByIdRequest_V1")]
public class AdminSearchUsersByIdRequest
{
    [ProtoMember(1)]
    public string? AccountId { get; set; }

    [ProtoMember(2)]
    public int Page { get; set; }

    [ProtoMember(3)]
    public int Count { get; set; }
}
