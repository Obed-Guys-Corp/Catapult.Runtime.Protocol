using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_PlayedUgcLevelsResponse_V1")]
public class PlayedUgcLevelsResponse
{
    [ProtoIgnore]
    private List<PlayedUgcLevelDto>? _history;

    [ProtoMember(1)]
    public List<PlayedUgcLevelDto> History { get; set; }
}
