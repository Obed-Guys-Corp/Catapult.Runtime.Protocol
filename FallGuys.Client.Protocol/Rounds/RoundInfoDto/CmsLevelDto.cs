using ProtoBuf;

namespace FallGuys.Client.Protocol.Rounds.RoundInfoDto;

[ProtoContract(Name = "FallGuys_Rounds_CmsLevelDto_V1")]
public class CmsLevelDto
{
    [ProtoMember(1)]
    public string? LevelsRoundContentId { get; set; }

    [ProtoMember(2)]
    public UgcLevelDto? FeaturedUgcLevel { get; set; }
}
