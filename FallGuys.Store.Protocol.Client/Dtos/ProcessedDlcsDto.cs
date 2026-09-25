using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos;

[ProtoContract(Name = "Catapult_Store_ProcessedDlcsDto_V1")]
public class ProcessedDlcsDto
{
    [ProtoMember(1)]
    public List<ItemAddedDto> ItemsAdded { get; set; } = null!;

    [ProtoMember(2)]
    public List<ItemRemovedDto> ItemsRemoved { get; set; } = null!;
}
