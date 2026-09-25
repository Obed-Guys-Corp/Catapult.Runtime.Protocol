using ProtoBuf;

namespace FallGuys.Client.Protocol.Rounds.RoundInfoDto;

[ProtoContract(Name = "FallGuys_Rounds_RoundInfoDto_V1")]
public class RoundInfoDto
{
    [ProtoMember(1)]
    public int RoundIndex { get; set; }

    [ProtoMember(2)]
    public SelectedLevelDto? Level { get; set; }

    [ProtoMember(3)]
    public string? RoundPoolId { get; set; }

    [ProtoMember(4)]
    public string? RewardsContentId { get; set; }
}
