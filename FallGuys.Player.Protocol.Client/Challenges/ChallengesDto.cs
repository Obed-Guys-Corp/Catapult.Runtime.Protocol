using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Challenges;

[ProtoContract(Name = "FallGuys_Player_ChallengesDto_V1")]
public class ChallengesDto
{
    [ProtoIgnore]
    private Dictionary<int, ChallengeDto>? _challenges;

    [ProtoMember(1)]
    public Dictionary<int, ChallengeDto> Challenges { get; set; }

    [ProtoMember(2)]
    public DateTime NextRefreshAt { get; set; }
}
