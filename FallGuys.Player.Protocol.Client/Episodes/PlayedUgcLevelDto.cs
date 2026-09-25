using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_PlayedUgcLevelDto_V1")]
public class PlayedUgcLevelDto
{
    [ProtoMember(1)]
    public string? ShareCode { get; set; }

    [ProtoMember(2)]
    public int Version { get; set; }

    [ProtoMember(3)]
    public DateTime LastPlayedAt { get; set; }

    [ProtoMember(4)]
    public int TimesPlayed { get; set; }
}
