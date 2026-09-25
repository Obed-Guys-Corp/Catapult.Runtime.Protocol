using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Requests.Admin;

[ProtoContract(Name = "Catapult_Login_AdminRemoveIdentityRequest_V1")]
[Authorize(Roles = new string[] { "Admin" })]
public class AdminRemoveIdentityRequest
{
	[ProtoMember(1)]
	public string? IdentityId { get; set; }
}
