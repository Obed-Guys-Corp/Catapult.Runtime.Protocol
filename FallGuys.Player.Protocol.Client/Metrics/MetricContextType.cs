using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Metrics;

[ProtoContract(Name = "FallGuys_Player_MetricContextType_V1")]
public enum MetricContextType
{
	[ProtoEnum(Name = "unknown", Value = 0)]
	Unknown,
	[ProtoEnum(Name = "private_lobby", Value = 1)]
	PrivateLobby
}
