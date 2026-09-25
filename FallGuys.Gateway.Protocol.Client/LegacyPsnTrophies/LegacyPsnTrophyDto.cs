using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.LegacyPsnTrophies;

[ProtoContract(Name = "FallGuys_Gateway_LegacyPsnTrophyDto_V1")]
public class LegacyPsnTrophyDto
{
    [ProtoMember(1)]
    public int TrophyId { get; set; }

    [ProtoMember(2)]
    public bool Earned { get; set; }

    [ProtoMember(3)]
    public string TrophyType { get; set; }

    [ProtoMember(4)]
    public string TrophyName { get; set; }
}
