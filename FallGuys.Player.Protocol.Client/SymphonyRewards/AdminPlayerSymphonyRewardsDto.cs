using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.SymphonyRewards;

[Authorize(Roles = new string[] { CoreRoles.Admin })]
[ProtoContract(Name = "FallGuys_AdminPlayerSymphonyRewardsDto_V1")]
public class AdminPlayerSymphonyRewardsDto
{
    [ProtoMember(1)]
    public List<SymphonyRewardDto> Rewards { get; set; } = null!;

    [ProtoMember(2)]
    public SymphonyConversionDto? SymphonyConversion { get; set; }
}
