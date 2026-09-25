using ProtoBuf;

namespace FallGuys.Client.Protocol.Rounds.RoundInfoDto;

[ProtoContract(Name = "FallGuys_Rounds_SelectedLevelDto_V1")]
public class SelectedLevelDto
{
    [ProtoMember(1)]
    public string? Source { get; set; }

    [ProtoMember(2)]
    public UgcLevelDto? UgcLevel { get; set; }

    [ProtoMember(3)]
    public CmsLevelDto? CmsLevel { get; set; }
}
