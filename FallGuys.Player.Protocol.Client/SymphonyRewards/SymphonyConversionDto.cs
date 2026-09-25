using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.SymphonyRewards;

[ProtoContract(Name = "FallGuys_SymphonyConversionDto_V1")]
public class SymphonyConversionDto
{
    [ProtoMember(1)]
    public bool IsCompleted { get; set; }

    [ProtoMember(2)]
    public int CrownsConverted { get; set; }

    [ProtoMember(3)]
    public int KudosGiven { get; set; }

    [ProtoMember(4)]
    public int ConversionRatio { get; set; }

    [ProtoMember(5)]
    public DateTime? HappenedAt { get; set; }
}
