using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Achievements;

[ProtoContract(Name = "FallGuys_Player_TrackAchievementsProgressionCommand_V1")]
[Authorize(Roles = new string[] { "User" })]
public class TrackAchievementsProgressionCommand
{
	private List<AchievementProgressDto>? _achievementProgressList;

	[ProtoMember(1)]
	public List<AchievementProgressDto> AchievementProgressList
	{
		get
		{
			return _achievementProgressList ?? (_achievementProgressList = new List<AchievementProgressDto>());
		}
		set
		{
			_achievementProgressList = value;
		}
	}
}
