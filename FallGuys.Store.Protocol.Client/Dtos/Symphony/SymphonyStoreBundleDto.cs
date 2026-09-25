using FallGuys.Common.Targeting.Protocol.Client;
using ProtoBuf;
using System;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_StoreBundleDto_V1")]
public class SymphonyStoreBundleDto
{
    [ProtoMember(1)]
    public string? BundleId { get; set; }

    [ProtoMember(2)]
    public int Index { get; set; }

    [ProtoMember(3)]
    public string? BundleSlotId { get; set; }

    [ProtoMember(4)]
    public string? CategoryName { get; set; }

    [ProtoMember(5)]
    public int? Stock { get; set; }

    [ProtoMember(6)]
    public TargetingResultDto? TargetingResult { get; set; }

    [ProtoMember(7)]
    public bool HasStock { get; set; }

    [ProtoMember(8)]
    public DateTime? StartDate { get; set; }

    [ProtoMember(9)]
    public DateTime? EndDate { get; set; }

    [ProtoMember(10)]
    public bool WasReturnedOnce { get; set; }
}
