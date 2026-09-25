using ProtoBuf;

namespace FallGuys.Common.Targeting.Protocol.Client;

[ProtoContract(Name = "FallGuys_Player_TargetingResultDto_V1")]
public class TargetingResultDto
{
    [ProtoMember(1)]
    public string? ContentReference { get; set; }

    [ProtoMember(2)]
    public bool IsTargetMet { get; set; }

    [ProtoMember(3)]
    public bool IsCacheable { get; set; }

    [ProtoMember(4)]
    public AvailabilityWindowDto? AvailabilityWindow { get; set; }
}
