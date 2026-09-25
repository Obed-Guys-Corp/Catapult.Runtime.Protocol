using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.CreateLobby;

[ProtoContract(Name = "FallGuys_Lobby_Matchmaking_QosResultDto_V1")]
public class QosResultDto
{
	[ProtoMember(1)]
	public string RegionId { get; set; }

	[ProtoMember(2)]
	public float PacketLoss { get; set; }

	[ProtoMember(3)]
	public uint MillisecondLatency { get; set; }
}
