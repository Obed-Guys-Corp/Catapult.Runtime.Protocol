using ProtoBuf;

namespace FallGuys.Client.Protocol.Rounds.RoundInfoDto;

[ProtoContract(Name = "FallGuys_Rounds_UgcLevelDto_V1")]
public class UgcLevelDto
{
    [ProtoMember(1)]
    public string? ShareCode { get; set; }

    [ProtoMember(2)]
    public int Version { get; set; }

    [ProtoMember(3)]
    public string? SceneUrl { get; set; }
}
