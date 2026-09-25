using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.SeasonPasses;

[ProtoContract(Name = "FallGuys_Player_SeasonPassesResponse_V1")]
public class SeasonPassesDto
{
	[ProtoMember(1)]
	public HashSet<string>? SeasonPassIds { get; set; }
}
