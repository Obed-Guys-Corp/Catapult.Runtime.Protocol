using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Profile;

[ProtoContract(Name = "FallGuys_Player_RandomNameDto_V1")]
public class RandomNameDto
{
    [ProtoMember(1)]
    public PlayerNameDto PlayerNameDto { get; set; }

    [ProtoMember(2)]
    public string TokenisedName { get; set; }
}
