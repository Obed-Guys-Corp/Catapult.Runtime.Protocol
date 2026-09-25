using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Rewards;

[ProtoContract(Name = "FallGuys_Player_BulkClaimRewardsCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class BulkClaimRewardsCommand
{
    [ProtoMember(1)]
    public List<string> RewardIds { get; set; } = null!;
}
