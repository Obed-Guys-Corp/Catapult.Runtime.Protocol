using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Preview;

[ProtoContract(Name = "FallGuys_Lobby_Client_Read_PreviewLobbyDataDto_V1")]
public class PreviewLobbyConfigDto
{
    [ProtoMember(1)]
    public RawJsonDto? LevelMetaDataJson { get; set; }
}
