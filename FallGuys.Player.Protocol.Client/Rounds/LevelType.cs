using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rounds;

[ProtoContract(Name = "FallGuys_Player_Rounds_LevelType_V1")]
public enum LevelType
{
    [ProtoEnum(Name = "unknown")]
    Unknown,
    [ProtoEnum(Name = "cms")]
    Cms,
    [ProtoEnum(Name = "ugc")]
    Ugc
}
