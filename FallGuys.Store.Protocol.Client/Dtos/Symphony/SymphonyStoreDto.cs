using FallGuys.Common.Targeting.Protocol.Client;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_StoreDto_V1")]
public class SymphonyStoreDto
{
    [ProtoMember(1)]
    public string? Id { get; set; }

    [ProtoMember(2)]
    public List<SymphonyStorefrontDto> Storefronts { get; set; } = null!;

    [ProtoMember(3)]
    public TargetingResultDto? TargetingResult { get; set; }
}
