using Catapult.Protocol.Content;
using ProtoBuf;
using System.ComponentModel;

namespace FallGuys.Client.Protocol.ShowSelector.GetShowSelector;

[ProtoContract(Name = "FallGuys_ShowSelector_Get_GateDto_V1")]
public class GateDto
{
    [ProtoMember(1)]
    public ContentItemIdDto? ShowContentId { get; set; }

    [ProtoMember(2)]
    public GateStatus Status { get; set; }

    [ProtoMember(3)]
    public GateStatus? NextStatus { get; set; }

    [ProtoMember(4)]
    public int? RoundsPlayedUntilNextStatus { get; set; }

    [ProtoMember(5)]
    [DefaultValue(true)]
    public bool IsShowVisible { get; set; }
}
