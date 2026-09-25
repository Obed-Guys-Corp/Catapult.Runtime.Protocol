using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Lobbies.Modes.Debug;

[ProtoContract(Name = "FallGuys_Lobby_Client_Read_DebugLobbyConfigDto_V1")]
public class DebugLobbyConfigDto
{
    [ProtoMember(1)]
    public int? MinPlayerCount { get; set; }

    [ProtoMember(2)]
    public int? MaxPlayerCount { get; set; }

    [ProtoMember(3)]
    public int BotCount { get; set; }

    [ProtoMember(4)]
    public string? ShowContentId { get; set; }
}
