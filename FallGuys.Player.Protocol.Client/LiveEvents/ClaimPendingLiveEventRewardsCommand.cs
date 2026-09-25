using System;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[ProtoContract(Name = "FallGuys_Player_ClaimPendingLiveEventRewardsCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
[Obsolete("This command is now deprecated. Please use the ClaimRewardsCommand API instead.")]
public class ClaimPendingLiveEventRewardsCommand
{
	[ProtoMember(1)]
	public string? LiveEventId { get; set; }

	[ProtoMember(2)]
	public int? MilestoneXp { get; set; }
}
