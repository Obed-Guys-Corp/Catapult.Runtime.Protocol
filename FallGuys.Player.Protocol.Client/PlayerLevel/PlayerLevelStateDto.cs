using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.PlayerLevel;

[ProtoContract(Name = "FallGuys_Player_PlayerLevelTierDto_V1")]
public class PlayerLevelStateDto
{
    [ProtoMember(1)]
    public int Index { get; set; }

    [ProtoMember(2)]
    public int CrownsRequired { get; set; }

    [ProtoMember(3)]
    public DateTime? UnlockedAt { get; set; }

    [ProtoMember(4)]
    public string RewardId { get; set; }

    [ProtoMember(5)]
    public bool IsAcknowledged { get; set; }

    [ProtoMember(6)]
    public bool IsMilestone { get; set; }
}
