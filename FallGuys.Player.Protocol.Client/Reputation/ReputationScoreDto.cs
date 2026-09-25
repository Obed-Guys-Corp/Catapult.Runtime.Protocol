using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Reputation;

[ProtoContract(Name = "FallGuys_Player_ReputationScoreDto_V1")]
public class ReputationScoreDto
{
    [ProtoMember(1)]
    public int ReputationScore { get; set; }

    [ProtoMember(2)]
    public bool IsPlayerCheater { get; set; }
}
