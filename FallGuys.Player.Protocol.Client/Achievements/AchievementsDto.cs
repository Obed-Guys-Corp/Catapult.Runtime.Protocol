using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Achievements;

[ProtoContract(Name = "FallGuys_Player_AchievementsDto_V1")]
public class AchievementsDto
{
	private List<AchievementDto>? _achievements;

	[ProtoMember(1)]
	public List<AchievementDto> Achievements
	{
		get
		{
			return _achievements ?? (_achievements = new List<AchievementDto>());
		}
		set
		{
			_achievements = value;
		}
	}
}
