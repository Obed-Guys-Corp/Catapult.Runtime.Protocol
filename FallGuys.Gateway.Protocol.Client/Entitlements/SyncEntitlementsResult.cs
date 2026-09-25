using Catapult.Modules.Items.Protocol.Dtos;
using FallGuys.Player.Protocol.Client.Rewards;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Gateway.Protocol.Client.Entitlements;

[ProtoContract(Name = "FallGuys_Gateway_EntitlementsSyncResult_V1")]
public class SyncEntitlementsResult
{
    [ProtoMember(1)]
    public List<ItemAddedDto> ItemsGained { get; set; } = null!;

    [ProtoMember(2)]
    public List<ItemRemovedDto> ItemsLost { get; set; } = null!;

    [ProtoMember(3)]
    public List<RewardDto> Rewards { get; set; } = null!;
}
