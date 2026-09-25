using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Rewards;

[ProtoContract(Name = "FallGuys_Player_ClaimRewardsCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class ClaimRewardsCommand
{
    private List<string>? _rewardItemIds;

    [ProtoMember(1)]
    public List<string> RewardItemIds { get; set; }
}
