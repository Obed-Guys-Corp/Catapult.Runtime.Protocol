using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Client.Protocol.ShowSelector.GetShowSelector;

[ProtoContract(Name = "FallGuys_ShowSelector_Get_ShowSelectorDto_V1")]
public class ShowSelectorDto
{
    private List<ShowDto>? _shows;

    [ProtoMember(1)]
    public List<ShowDto> Shows { get; set; }
}
