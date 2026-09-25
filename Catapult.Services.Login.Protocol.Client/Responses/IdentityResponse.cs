using ProtoBuf;

namespace Catapult.Services.Login.Protocol.Client.Responses;

[ProtoContract(Name = "Catapult_Login_IdentityResponse_V1")]
public class IdentityResponse
{
	[ProtoMember(1)]
	public string? Type { get; set; }

	[ProtoMember(2)]
	public string? Token { get; set; }

	[ProtoMember(3)]
	public string? Id { get; set; }

	[ProtoMember(4)]
	public string? AccountId { get; set; }
}
