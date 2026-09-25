using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[ProtoContract(Name = "FallGuys_Player_LiveEventsDto_V1")]
public class LiveEventsDto
{
	[ProtoMember(1)]
	public LiveEventDto? CurrentLiveEvent { get; set; }

	[ProtoMember(2)]
	public List<LiveEventDto>? LiveEventsWithUnclaimedRewards { get; set; }
}
