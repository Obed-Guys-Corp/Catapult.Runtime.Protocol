using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Requests;

[ProtoContract(Name = "Catapult_Login_AuthenticateRequest_V1")]
[Authorize(AllowAnonymous = true)]
public class AuthenticateRequest
{
	[ProtoMember(1)]
	public string? Token { get; set; }
}
