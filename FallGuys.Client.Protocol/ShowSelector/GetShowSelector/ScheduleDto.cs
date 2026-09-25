using ProtoBuf;
using System;

namespace FallGuys.Client.Protocol.ShowSelector.GetShowSelector;

[ProtoContract(Name = "FallGuys_ShowSelector_Get_ScheduleDto_V1")]
public class ScheduleDto
{
    [ProtoMember(1)]
    public DateTime OpensAt { get; set; }

    [ProtoMember(2)]
    public DateTime ClosesAt { get; set; }
}
