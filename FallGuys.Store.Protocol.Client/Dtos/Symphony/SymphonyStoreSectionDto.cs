using FallGuys.Common.Targeting.Protocol.Client;
using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_StoreSectionDto_V1")]
public class SymphonyStoreSectionDto
{
    [ProtoMember(1)]
    public string? Id { get; set; }

    [ProtoMember(4)]
    public DateTime? NextRefreshAt { get; set; }

    [ProtoMember(5)]
    public List<SymphonyStoreBundleDto> Bundles { get; set; } = null!;

    [ProtoMember(6)]
    public TargetingResultDto? TargetingResult { get; set; }
}
