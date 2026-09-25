using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_LiveEvents_DebugProgressLiveEventChallengeCommand_V1")]
public class DebugProgressLiveEventChallengeCommand
{
	[ProtoMember(1)]
	public string? GoalId { get; set; }

	[ProtoMember(2)]
	public int Progress { get; set; }
}
