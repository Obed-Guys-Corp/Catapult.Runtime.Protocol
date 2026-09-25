using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_LiveEvents_DebugCompleteLiveEventCommand_V1")]
public class DebugCompleteLiveEventCommand
{
    [ProtoMember(1)]
    public string? LiveEventId { get; set; }
}
