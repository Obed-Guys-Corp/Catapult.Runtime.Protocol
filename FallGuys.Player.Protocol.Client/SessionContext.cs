using ProtoBuf;

namespace FallGuys.Player.Protocol.Client;

[ProtoContract(Name = "FallGuys_Player_SessionContext_V1")]
public enum SessionContext
{
    [ProtoEnum(Name = "unknown")]
    Unknown,
    [ProtoEnum(Name = "public_match")]
    PublicMatch,
    [ProtoEnum(Name = "private_lobby")]
    PrivateLobby,
    [ProtoEnum(Name = "discovery")]
    Discovery
}
