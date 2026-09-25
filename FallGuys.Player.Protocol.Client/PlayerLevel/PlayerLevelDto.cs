using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.PlayerLevel;

[ProtoContract(Name = "FallGuys_Player_PlayerLevelDto_V1")]
public class PlayerLevelDto
{
    [ProtoMember(1)]
    public int EarnedCrowns { get; set; }

    [ProtoMember(2)]
    public List<PlayerLevelStateDto> Levels { get; set; } = null!;
}
