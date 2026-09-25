using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Rounds;

[ProtoContract(Name = "FallGuys_Player_Rounds_RoundResultsResponse_V1")]
public class RoundResultsResponse
{
    [ProtoMember(1)]
    public List<RoundResultDto> RoundResults { get; set; } = null!;
}
