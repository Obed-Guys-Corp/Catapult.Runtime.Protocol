using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.ShowSelector;

[ProtoContract(Name = "FallGuys_Player_ActiveShowsDto_V1")]
public class ActiveShowsDto
{
	[ProtoMember(1)]
	public List<ShowDto> Shows { get; set; }
}
