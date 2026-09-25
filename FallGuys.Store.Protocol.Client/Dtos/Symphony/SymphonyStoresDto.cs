using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_StoresDto_V1")]
public class SymphonyStoresDto
{
    [ProtoMember(1)]
    public List<SymphonyStoreDto> Stores { get; set; } = null!;
}
