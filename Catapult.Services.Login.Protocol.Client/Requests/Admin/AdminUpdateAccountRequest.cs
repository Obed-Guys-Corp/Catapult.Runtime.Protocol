using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace Catapult.Services.Login.Protocol.Client.Requests.Admin;

[ProtoContract(Name = "Catapult_Login_AdminUpdateAccountRequest_V1")]
[Authorize(Roles = new string[] { CoreRoles.Admin, CoreRoles.Super })]
public class AdminUpdateAccountRequest
{
    [ProtoMember(1)]
    public string? AccountId { get; set; }

    [ProtoMember(2)]
    public bool IsBanned { get; set; }

    [ProtoMember(3)]
    public List<string> Roles { get; set; } = null!;

    [ProtoMember(4)]
    public bool ShouldLogRequests { get; set; }
}
