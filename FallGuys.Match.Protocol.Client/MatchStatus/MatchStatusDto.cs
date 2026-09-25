using FallGuys.Client.Protocol.GameServers;
using FallGuys.Client.Protocol.Networking;
using FallGuys.Client.Protocol.Rounds.RoundInfoDto;
using ProtoBuf;

namespace FallGuys.Match.Protocol.Client.MatchStatus;

[ProtoContract(Name = "FallGuys_Match_MatchStatusDto_V1")]
public class MatchStatusDto
{
    [ProtoMember(1)]
    public MatchStatus MatchStatus { get; set; }

    [ProtoMember(2)]
    public string? IpAddress { get; set; }

    [ProtoMember(3)]
    public int? Port { get; set; }

    [ProtoMember(4)]
    public string? GameServerToken { get; set; }

    [ProtoMember(5)]
    public int PlayerCount { get; set; }

    [ProtoMember(6)]
    public int BotCount { get; set; }

    [ProtoMember(7)]
    public RoundInfoDto? CurrentRound { get; set; }

    [ProtoMember(8)]
    public string? BucketId { get; set; }

    [ProtoMember(9)]
    public PollingStrategyDto GameServerInfoPollingStrat { get; set; } = null!;

    [ProtoMember(10)]
    public GameServerConnectionDto? GameServerInfo { get; set; }
}
