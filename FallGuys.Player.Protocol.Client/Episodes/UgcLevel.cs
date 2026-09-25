using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_UgcLevel_V1")]
public class UgcLevel
{
	[ProtoMember(1)]
	public string? ShareCode { get; set; }

	[ProtoMember(2)]
	public int Version { get; set; }
}
