using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Stats;

[ProtoContract(Name = "FallGuys_Player_PlayerStatsDto_V1")]
public class PlayerStatsDto
{
	[ProtoMember(1)]
	public List<PlayerStatDto>? Stats { get; set; }
}
