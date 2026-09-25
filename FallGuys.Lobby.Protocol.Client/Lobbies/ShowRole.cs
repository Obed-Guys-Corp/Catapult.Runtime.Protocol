using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Lobbies;

[ProtoContract(Name = "FallGuys_Lobby_LobbyParticipantRole_V1")]
public enum ShowRole
{
    [ProtoEnum(Name = "Player")]
    Player,
    [ProtoEnum(Name = "Spectator")]
    Spectator
}
