using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_EpisodeHistoryDto_V1")]
public class EpisodeHistoryDto
{
    [ProtoMember(1)]
    public int CurrentStreak { get; set; }

    [ProtoMember(2)]
    public int HighestStreak { get; set; }
}
