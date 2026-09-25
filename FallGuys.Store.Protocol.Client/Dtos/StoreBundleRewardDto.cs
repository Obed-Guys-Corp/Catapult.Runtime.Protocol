using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_StoreBundleRewardDto_V1")]
public class StoreBundleRewardDto
{
    [ProtoMember(1)]
    public List<StoreBundleItemDto> Items { get; set; } = null!;
}
