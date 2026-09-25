using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking.Identity;

[ProtoContract(Name = "FallGuys_Gateway_Matchmaking_MatchmakingIdentityTokenDto_V1")]
public class MatchmakingIdentityTokenDto
{
	[ProtoMember(1)]
	public string Value { get; set; }
}
