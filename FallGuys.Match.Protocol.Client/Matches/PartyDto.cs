using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Match.Protocol.Client.Matches;

[ProtoContract(Name = "FallGuys_Match_PartyDto_V1")]
public class PartyDto
{
    private List<PlayerDto>? _players;

    [ProtoMember(1)]
    public int? GroupId { get; set; }

    [ProtoMember(2)]
    public List<PlayerDto> Players { get; set; }
}
