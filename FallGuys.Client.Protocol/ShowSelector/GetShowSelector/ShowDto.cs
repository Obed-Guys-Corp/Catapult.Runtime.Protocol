using Catapult.Protocol.Content;
using ProtoBuf;

namespace FallGuys.Client.Protocol.ShowSelector.GetShowSelector;

[ProtoContract(Name = "FallGuys_ShowSelector_Get_ShowDto_V1")]
public class ShowDto
{
    private GateDto? _gate;
    private ScheduleDto? _schedule;

    [ProtoMember(1)]
    public ContentItemIdDto? ShowId { get; set; }

    [ProtoMember(2)]
    public GateDto Gate { get; set; }

    [ProtoMember(3)]
    public ScheduleDto Schedule { get; set; }
}
