using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Store.Protocol.Client.Dtos.Symphony;

[ProtoContract(Name = "FallGuys_Store_SeasonPassBundleDto_V1")]
public class SeasonPassBundleDto : SymphonyStoreBundleDto
{
    private List<SeasonPassOptionDto>? _options;

    [ProtoMember(1)]
    public List<SeasonPassOptionDto> Options { get; set; }
}
