using System;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking.Fn;

[ProtoContract(Name = "FallGuys_Matchmaking_EventDto_V1")]
public class EventDto
{
	[ProtoMember(1)]
	public string? Name { get; set; }

	[ProtoMember(2)]
	public DateTime Timestamp { get; set; }

	[ProtoMember(3)]
	public string? Status { get; set; }
}
