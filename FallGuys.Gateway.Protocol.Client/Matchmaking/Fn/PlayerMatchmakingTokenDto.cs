using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking.Fn;

[ProtoContract(Name = "FallGuys_Gateway_PlayerMatchmakingTokenDto_V1")]
public class PlayerMatchmakingTokenDto
{
	[ProtoMember(1)]
	public string? Payload { get; set; }

	[ProtoMember(2)]
	public string? Signature { get; set; }

	[ProtoMember(3)]
	public string? ConnectionString { get; set; }

	[ProtoMember(4)]
	public string? MetaDataToken { get; set; }
}
