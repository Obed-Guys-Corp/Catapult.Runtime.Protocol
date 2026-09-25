using Catapult.Modules.Items.Protocol.Dtos;
using FallGuys.Player.Protocol.Client.Rewards;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Gateway.Protocol.Client.Entitlements;

[ProtoContract(Name = "FallGuys_Gateway_EntitlementsSyncResult_V1")]
public class SyncEntitlementsResult
{
    private List<ItemAddedDto>? _itemsGained;
    private List<ItemRemovedDto>? _itemsLost;
    private List<RewardDto>? _rewards;

    [ProtoMember(1)]
    public List<ItemAddedDto> ItemsGained { get; set; }

    [ProtoMember(2)]
    public List<ItemRemovedDto> ItemsLost { get; set; }

    [ProtoMember(3)]
    public List<RewardDto> Rewards { get; set; }
}
