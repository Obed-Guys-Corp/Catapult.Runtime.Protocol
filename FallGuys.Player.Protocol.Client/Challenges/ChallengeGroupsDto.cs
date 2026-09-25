using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Challenges;

[ProtoContract(Name = "FallGuys_Player_ChallengeGroupsDto_V1")]
public class ChallengeGroupsDto
{
    [ProtoIgnore]
    private List<ChallengeGroupDto>? _challengeLists;

    [ProtoMember(1)]
    public List<ChallengeGroupDto> ChallengeGroups { get; set; }

    [ProtoMember(2)]
    public DateTime? NextRefreshAt { get; set; }
}
