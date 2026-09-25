using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Compensation;

[ProtoContract(Name = "FallGuys_Player_PlayerContentMetadataDto_V1")]
public class PlayerContentMetadataDto
{
	[ProtoMember(1)]
	public string? Category { get; set; }

	[ProtoMember(2)]
	public Dictionary<string, string>? Value { get; set; }
}
