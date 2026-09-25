using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.CreateLobby.Modes.Preview;

[ProtoContract(Name = "FallGuys_Lobby_Client_Create_PreviewLobbyConfigDto_V1")]
public class PreviewLobbyConfigDto
{
    [ProtoMember(1)]
    public string? LevelMetaDataToken { get; set; }
}
