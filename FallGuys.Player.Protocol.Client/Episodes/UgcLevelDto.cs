using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_UgcLevel_V1")]
public class UgcLevelDto
{
    [ProtoMember(1)]
    public string? ShareCode { get; set; }

    [ProtoMember(2)]
    public int Version { get; set; }

    [ProtoMember(3)]
    public List<string> CreatorTags { get; set; } = null!;

    [ProtoMember(4)]
    public string? GameMode { get; set; }
}
