using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.CreateLobby.Modes.Private.Show.Discovery;

[ProtoContract(Name = "FallGuys_Lobby_Client_Create_DiscoveryShowConfigDto_V1")]
public class DiscoveryShowConfigDto
{
    [ProtoMember(1)]
    public string? PlaylistToken { get; set; }

    [ProtoMember(2)]
    public string? DiscoveryQueryId { get; set; }
}
