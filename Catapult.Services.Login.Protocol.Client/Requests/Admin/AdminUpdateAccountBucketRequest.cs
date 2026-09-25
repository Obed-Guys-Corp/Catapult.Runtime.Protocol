using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Requests.Admin;

[ProtoContract(Name = "Catapult_Login_AdminUpdateAccountBucketRequest_V1")]
[Authorize(Roles = new string[] { CoreRoles.Admin, CoreRoles.Super })]
public class AdminUpdateAccountBucketRequest
{
	[ProtoMember(1)]
	public string? AccountId { get; set; }

	[ProtoMember(2)]
	public int? Bucket { get; set; }
}
