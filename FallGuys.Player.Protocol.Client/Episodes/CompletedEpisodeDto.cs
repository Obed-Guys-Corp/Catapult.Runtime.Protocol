using Catapult.Modules.Items.Protocol.Dtos;
using FallGuys.Player.Protocol.Client.RankedMode;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_CompletedEpisodeDto_V1")]
public class CompletedEpisodeDto
{
    [ProtoMember(1)]
    public string EpisodeId { get; set; }

    [ProtoMember(2)]
    public ItemAddedDto CrownsEarned { get; set; }

    [ProtoMember(8)]
    public int CurrentCrownShards { get; set; }

    [ProtoMember(3)]
    public List<CompletedRoundDto> Rounds { get; set; }

    [ProtoMember(4)]
    public SeasonProgressDto SeasonProgress { get; set; }

    [ProtoMember(7)]
    public PlayerLevelProgressDto PlayerLevelProgress { get; set; }

    [ProtoMember(9)]
    public List<ItemAddedDto> ItemsAwarded { get; set; }

    [ProtoMember(10)]
    public RankedScoreChangesDto RankedScoreChanges { get; set; }
}
