using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Private.Show.Discovery;

[ProtoContract(Name = "FallGuys_Lobby_Client_Read_DiscoveryShowConfigDto_V1")]
public class DiscoveryShowConfigDto
{
    [ProtoMember(1)]
    public RawJsonDto? PlaylistJson { get; set; }

    [ProtoMember(2)]
    public string? DiscoveryQueryId { get; set; }
}
