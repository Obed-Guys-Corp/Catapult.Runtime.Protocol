using System;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.ShowSelector;

[ProtoContract(Name = "FallGuys_Player_ShowDto_V1")]
public class ShowDto
{
	[ProtoMember(1)]
	public string ShowId { get; set; }

	[ProtoMember(2)]
	public DateTime OpensAt { get; set; }

	[ProtoMember(3)]
	public DateTime? ClosesAt { get; set; }

	[ProtoMember(4)]
	public bool IsDefault { get; set; }

	[ProtoMember(5)]
	public int MinPlayerCount { get; set; }

	[ProtoMember(6)]
	public int MaxPlayerCount { get; set; }
}
