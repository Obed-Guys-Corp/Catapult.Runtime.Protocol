using System;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rewards;

[ProtoContract(Name = "FallGuys_Client_RewardDto_V1")]
public class RewardDto
{
	[ProtoMember(1)]
	public string? Id { get; set; }

	[ProtoMember(2)]
	public string? ContentReference { get; set; }

	[ProtoMember(3)]
	public DateTime EarnedAt { get; set; }

	[ProtoMember(4)]
	public string? Context { get; set; }
}
