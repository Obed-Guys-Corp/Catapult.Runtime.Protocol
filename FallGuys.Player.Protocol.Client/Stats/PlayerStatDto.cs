using System;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Stats;

[ProtoContract(Name = "FallGuys_Player_PlayerStatDto_V1")]
public class PlayerStatDto
{
	[ProtoMember(1)]
	public string? ContentId { get; set; }

	[ProtoMember(2)]
	public int? Value { get; set; }

	[ProtoMember(3)]
	public DateTime? TrackedFrom { get; set; }
}
