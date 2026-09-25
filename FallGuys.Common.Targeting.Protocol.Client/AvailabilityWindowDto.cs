using System;
using ProtoBuf;

namespace FallGuys.Common.Targeting.Protocol.Client;

[ProtoContract(Name = "FallGuys_Player_AvailabilityWindowDto_V1")]
public class AvailabilityWindowDto
{
	[ProtoMember(1)]
	public DateTime? StartsAt { get; set; }

	[ProtoMember(2)]
	public DateTime? EndsAt { get; set; }
}
