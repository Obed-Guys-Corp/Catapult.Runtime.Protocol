using ProtoBuf;

namespace FallGuys.Client.Protocol.Networking;

[ProtoContract(Name = "FallGuys_Networking_PollingStrategyDto_V1")]
public class PollingStrategyDto
{
    [ProtoMember(1)]
    public PollingStrategyType StrategyType { get; set; }

    [ProtoMember(2)]
    public int ListenTimeoutMs { get; set; }

    [ProtoMember(3)]
    public int PollTimeoutMs { get; set; }

    [ProtoMember(4)]
    public int PollRetryDelayMs { get; set; }

    [ProtoMember(5)]
    public int PollMaxAttemptCount { get; set; }
}
