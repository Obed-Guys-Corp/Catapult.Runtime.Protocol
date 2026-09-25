using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Client.Protocol.ShowSelector.GetShowSelector;

[ProtoContract(Name = "FallGuys_ShowSelector_Get_ShowSelectorDto_V1")]
public class ShowSelectorDto
{
    [ProtoMember(1)]
    public List<ShowDto> Shows { get; set; } = null!;
}
