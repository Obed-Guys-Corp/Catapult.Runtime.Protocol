using Catapult.Protocol;
using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[Obsolete("This command is now deprecated. Please use the ClaimRewardsCommand API instead.")]
[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_ClaimPendingLiveEventRewardsCommand_V1")]
public class ClaimPendingLiveEventRewardsCommand
{
    [ProtoMember(1)]
    public string? LiveEventId { get; set; }

    [ProtoMember(2)]
    public int? MilestoneXp { get; set; }
}
