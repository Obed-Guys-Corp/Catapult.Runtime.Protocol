using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.SkillScores;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_DebugOverrideSkillScoreCommand_V1")]
[DebugMessage]
public class DebugOverrideSkillScoreCommand
{
	[ProtoMember(1)]
	public int? ScoreOverride { get; set; }

	[ProtoMember(2)]
	public int? EpisodesCompletedOverride { get; set; }
}
