using ProtoBuf;

namespace FallGuys.Client.Protocol.GameServers;

[ProtoContract(Name = "FallGuys_GameServers_IpAndPortDto_V1")]
public class IpAndPortDto
{
    [ProtoMember(1)]
    public string? Ip { get; set; }

    [ProtoMember(2)]
    public int Port { get; set; }
}
