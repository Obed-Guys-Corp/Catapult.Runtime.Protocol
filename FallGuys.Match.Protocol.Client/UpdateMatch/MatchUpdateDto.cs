using FallGuys.Match.Protocol.Client.Matches;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Match.Protocol.Client.UpdateMatch;

[ProtoContract(Name = "FallGuys_Match_MatchUpdateDto_V1")]
public class MatchUpdateDto
{
    private List<PartyDto>? _parties;

    [ProtoMember(1)]
    public string? MatchId { get; set; }

    [ProtoMember(2)]
    public List<PartyDto> Parties { get; set; }
}
