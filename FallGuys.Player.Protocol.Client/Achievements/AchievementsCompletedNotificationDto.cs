using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Achievements;

[ProtoContract(Name = "FallGuys_Player_AchievementsCompletedNotificationDto_V1")]
public class AchievementsCompletedNotificationDto
{
	[ProtoMember(1)]
	public string Id { get; set; }

	[ProtoMember(2)]
	public List<AchievementDto> Achievements { get; set; }
}
