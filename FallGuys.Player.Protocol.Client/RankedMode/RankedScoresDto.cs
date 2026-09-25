using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.RankedMode;

[ProtoContract(Name = "FallGuys_Player_RankedMode_RankedScoresDto_V1")]
public class RankedScoresDto
{
    [ProtoMember(1)]
    public List<RankedScoreDto>? RankedScores { get; set; }
}
