using System.Collections.Generic;
using FallGuys.Player.Protocol.Client.Rewards;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_PlayerLevelProgressDto_V1")]
public class PlayerLevelProgressDto
{
	[ProtoMember(1)]
	public Dictionary<int, RewardDto> LevelsUnlocked { get; set; }
}
