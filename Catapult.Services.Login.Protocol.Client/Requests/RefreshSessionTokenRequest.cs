using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Requests;

[Authorize(AllowAnonymous = true)]
[ProtoContract(Name = "Catapult_Login_RefreshSessionTokenRequest_V1")]
public class RefreshSessionTokenRequest
{
	[ProtoMember(1)]
	public string? SessionToken { get; set; }

	[ProtoMember(2)]
	public string? ContentVersion { get; set; }
}
