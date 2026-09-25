using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Seasons;

[ProtoContract(Name = "FallGuys_Player_SeasonHistoryDto_V1")]
public class SeasonHistoryDto
{
    [ProtoMember(1)]
    public string? SeasonId { get; set; }

    [ProtoMember(2)]
    public int AccruedFame { get; set; }

    [ProtoMember(3)]
    public List<SeasonFameTierDto>? FameTiers { get; set; }

    [ProtoMember(7)]
    public HashSet<string>? SeasonPassIds { get; set; }
}
