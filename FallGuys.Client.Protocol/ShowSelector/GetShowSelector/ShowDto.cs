using Catapult.Protocol.Content;
using ProtoBuf;

namespace FallGuys.Client.Protocol.ShowSelector.GetShowSelector;

[ProtoContract(Name = "FallGuys_ShowSelector_Get_ShowDto_V1")]
public class ShowDto
{
    [ProtoMember(1)]
    public ContentItemIdDto? ShowId { get; set; }

    [ProtoMember(2)]
    public GateDto Gate { get; set; } = null!;

    [ProtoMember(3)]
    public ScheduleDto Schedule { get; set; } = null!;
}
