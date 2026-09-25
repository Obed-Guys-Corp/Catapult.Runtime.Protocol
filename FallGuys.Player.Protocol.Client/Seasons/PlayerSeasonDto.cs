using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Seasons;

[ProtoContract(Name = "FallGuys_Player_PlayerSeasonDto_V1")]
public class PlayerSeasonDto
{
	[ProtoMember(1)]
	public SeasonHistoryDto CurrentSeason { get; set; }

	[ProtoMember(2)]
	public int AccumulatedFame { get; set; }

	[ProtoMember(3)]
	public List<SeasonHistoryDto> PreviousSeasons { get; set; }
}
