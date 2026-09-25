using ProtoBuf;
using System;

namespace FallGuys.Gateway.Protocol.Client.PlayerDisconnected;

[ProtoContract(Name = "FallGuys_Gateway_GameServerDisconnectNotification_V1")]
public class GameServerDisconnectNotification
{
    [ProtoMember(1)]
    public string PlayerId { get; set; } = null!;

    [ProtoMember(2)]
    public int ErrorCode { get; set; }

    [ProtoMember(3)]
    public DateTime TimeStamp { get; set; }

    [ProtoMember(4)]
    public string EpisodeId { get; set; } = null!;
}
