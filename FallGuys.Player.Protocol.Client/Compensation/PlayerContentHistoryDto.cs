using System;
using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Compensation;

[ProtoContract(Name = "FallGuys_Player_PlayerContentHistoryDto_V1")]
public class PlayerContentHistoryDto
{
	[ProtoMember(1)]
	public DateTime Timestamp { get; set; }

	[ProtoMember(2)]
	public List<PlayerContentMetadataDto>? Metadata { get; set; }
}
