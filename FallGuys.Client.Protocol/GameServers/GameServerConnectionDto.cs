using ProtoBuf;

namespace FallGuys.Client.Protocol.GameServers;

[ProtoContract(Name = "FallGuys_GameServers_ConnectionDto_V1")]
public class GameServerConnectionDto
{
    [ProtoMember(1)]
    public IpAndPortDto? IpAndPort { get; set; }

    [ProtoMember(2)]
    public int ConnectionTimeoutMs { get; set; }

    [ProtoMember(3)]
    public int ConnectionRetryDelayMs { get; set; }

    [ProtoMember(4)]
    public int MaxConnectionAttemptCount { get; set; }

    [ProtoMember(5)]
    public string? GameServerEntryToken { get; set; }
}
