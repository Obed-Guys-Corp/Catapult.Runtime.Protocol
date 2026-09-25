using ProtoBuf;

namespace FallGuys.Player.Protocol.Client;

[ProtoContract(Name = "FallGuys_Player_PlayerTagDto_V1")]
public class PlayerTagDto
{
    [ProtoMember(1)]
    public string Value { get; set; } = null!;

    [ProtoMember(2)]
    public string Description { get; set; } = null!;
}
