using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Requests.Admin;

[ProtoContract(Name = "Catapult_Login_AdminMigrateAccountRequest_V1")]
[Authorize(Roles = new string[] { CoreRoles.Admin, CoreRoles.Super })]
public class AdminMigrateDeviceIdsRequest
{
    [ProtoMember(1)]
    public string? NewOwningAccount { get; set; }

    [ProtoMember(2)]
    public string? PreviousOwningAccount { get; set; }
}
