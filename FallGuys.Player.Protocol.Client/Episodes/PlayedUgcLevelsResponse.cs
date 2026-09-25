using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_PlayedUgcLevelsResponse_V1")]
public class PlayedUgcLevelsResponse
{
    [ProtoMember(1)]
    public List<PlayedUgcLevelDto> History { get; set; } = null!;
}
