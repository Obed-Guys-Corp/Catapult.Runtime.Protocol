using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rounds;

[ProtoContract(Name = "FallGuys_Player_Rounds_SessionCorrelationDto_V1")]
public class RoundCorrelationDto
{
    [ProtoMember(1)]
    public int RoundIndex { get; set; }

    [ProtoMember(2)]
    public string? EpisodeId { get; set; }

    [ProtoMember(3)]
    public string? SeasonContentId { get; set; }
}
