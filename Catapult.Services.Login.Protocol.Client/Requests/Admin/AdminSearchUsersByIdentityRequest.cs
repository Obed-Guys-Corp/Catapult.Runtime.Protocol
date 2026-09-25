using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Requests.Admin;

[ProtoContract(Name = "Catapult_Login_AdminGetAccountsByIdentityRequest_V1")]
[Authorize(Roles = new string[] { "Admin", "Super" })]
public class AdminSearchUsersByIdentityRequest
{
	[ProtoMember(1)]
	public string? IdentityType { get; set; }

	[ProtoMember(2)]
	public string? IdentityToken { get; set; }

	[ProtoMember(3)]
	public int Page { get; set; }

	[ProtoMember(4)]
	public int Count { get; set; }
}
