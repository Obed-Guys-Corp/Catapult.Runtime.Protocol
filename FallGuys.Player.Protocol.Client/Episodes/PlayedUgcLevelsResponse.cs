using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_PlayedUgcLevelsResponse_V1")]
public class PlayedUgcLevelsResponse
{
	[ProtoIgnore]
	private List<PlayedUgcLevelDto>? _history;

	[ProtoMember(1)]
	public List<PlayedUgcLevelDto> History
	{
		get
		{
			return _history ?? (_history = new List<PlayedUgcLevelDto>());
		}
		set
		{
			_history = value;
		}
	}
}
