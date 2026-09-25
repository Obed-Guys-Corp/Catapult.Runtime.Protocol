using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Rewards;

[ProtoContract(Name = "FallGuys_Player_RewardClaimedDto_V1")]
public class RewardClaimedDto
{
    [ProtoMember(1)]
    public List<ItemAddedDto> ItemsGained { get; set; } = null!;

    [ProtoMember(2)]
    public List<ItemRemovedDto> ItemsLost { get; set; } = null!;
}
