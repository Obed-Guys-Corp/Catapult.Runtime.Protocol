using Catapult.Modules.Items.Protocol.Dtos;
using FallGuys.Player.Protocol.Client.RankedMode;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_CompletedEpisodeDto_V1")]
public class CompletedEpisodeDto
{
    [ProtoMember(1)]
    public string EpisodeId { get; set; } = null!;

    [ProtoMember(2)]
    public ItemAddedDto CrownsEarned { get; set; } = null!;

    [ProtoMember(8)]
    public int CurrentCrownShards { get; set; }

    [ProtoMember(3)]
    public List<CompletedRoundDto> Rounds { get; set; } = null!;

    [ProtoMember(4)]
    public SeasonProgressDto SeasonProgress { get; set; } = null!;

    [ProtoMember(7)]
    public PlayerLevelProgressDto PlayerLevelProgress { get; set; } = null!;

    [ProtoMember(9)]
    public List<ItemAddedDto> ItemsAwarded { get; set; } = null!;

    [ProtoMember(10)]
    public RankedScoreChangesDto RankedScoreChanges { get; set; } = null!;
}
