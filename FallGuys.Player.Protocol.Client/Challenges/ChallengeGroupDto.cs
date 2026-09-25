using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Challenges;

[ProtoContract(Name = "FallGuys_Player_ChallengeGroupDto_V1")]
public class ChallengeGroupDto
{
    [ProtoMember(1)]
    public string? Id { get; set; }

    [ProtoMember(2)]
    [Obsolete("Use ChallengeGroupContentId")]
    public string? ChallengeContentId { get; set; }

    [ProtoMember(6)]
    public string? ChallengeGroupContentId { get; set; }

    [ProtoMember(3)]
    public List<ChallengeDto> Challenges { get; set; } = null!;

    [ProtoMember(4)]
    public DateTime? NextRefreshDate { get; set; }

    [ProtoMember(5)]
    public bool IsSeen { get; set; }
}
