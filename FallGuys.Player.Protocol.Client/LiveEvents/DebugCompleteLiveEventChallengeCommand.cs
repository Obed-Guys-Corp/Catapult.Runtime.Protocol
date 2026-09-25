using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_LiveEvents_DebugCompleteLiveEventChallengeCommand_V1")]
public class DebugCompleteLiveEventChallengeCommand
{
    [ProtoMember(1)]
    public string? GoalId { get; set; }
}
