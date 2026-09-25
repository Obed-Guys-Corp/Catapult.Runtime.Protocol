using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking.Fn;

[ProtoContract(Name = "FallGuys_Gateway_Matchmaking_PartyMemberDto_V1")]
public class PartyMemberDto
{
	[ProtoMember(1)]
	public string? AccountId { get; set; }

	[ProtoMember(2)]
	public string? PlatformId { get; set; }
}
