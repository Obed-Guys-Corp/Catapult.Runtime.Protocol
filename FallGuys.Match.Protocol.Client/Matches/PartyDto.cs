using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Match.Protocol.Client.Matches;

[ProtoContract(Name = "FallGuys_Match_PartyDto_V1")]
public class PartyDto
{
	private List<PlayerDto>? _players;

	[ProtoMember(1)]
	public int? GroupId { get; set; }

	[ProtoMember(2)]
	public List<PlayerDto> Players
	{
		get
		{
			return _players ?? (_players = new List<PlayerDto>());
		}
		set
		{
			_players = value;
		}
	}
}
