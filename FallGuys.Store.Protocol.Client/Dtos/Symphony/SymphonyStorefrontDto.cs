using FallGuys.Common.Targeting.Protocol.Client;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_StorefrontDto_V1")]
public class SymphonyStorefrontDto
{
    [ProtoMember(1)]
    public string? Id { get; set; }

    [ProtoMember(2)]
    public List<SymphonyStoreSectionDto> Sections { get; set; } = null!;

    [ProtoMember(3)]
    public TargetingResultDto? TargetingResult { get; set; }
}
