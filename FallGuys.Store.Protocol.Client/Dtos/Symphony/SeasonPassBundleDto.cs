using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_SeasonPassBundleDto_V1")]
public class SeasonPassBundleDto : SymphonyStoreBundleDto
{
    [ProtoMember(1)]
    public List<SeasonPassOptionDto> Options { get; set; } = null!;
}
