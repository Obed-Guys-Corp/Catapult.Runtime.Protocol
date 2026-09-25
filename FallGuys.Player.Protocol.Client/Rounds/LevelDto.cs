using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rounds;

[ProtoContract(Name = "FallGuys_Player_Rounds_Level_V1")]
public class LevelDto
{
    [ProtoMember(1)]
    public LevelType Type { get; set; }

    [ProtoMember(2)]
    public string? CmsLevelId { get; set; }

    [ProtoMember(3)]
    public string? CmsShowId { get; set; }

    [ProtoMember(4)]
    public string? UgcShareCode { get; set; }
}
