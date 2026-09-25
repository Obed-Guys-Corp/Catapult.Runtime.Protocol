using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes;

[ProtoContract(Name = "FallGuys_Player_DiscoveryDto_V1")]
public class DiscoveryDto
{
    [ProtoMember(1)]
    public string? DiscoveryQueryId { get; set; }
}
