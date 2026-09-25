using Catapult.Protocol;
using ProtoBuf;
using System;

namespace FallGuys.Lobby.Protocol.Client.CloseLobby;

[ProtoContract(Name = "FallGuys_Lobby_CloseLobbyCommand_V1")]
[Obsolete("Use 'LeaveLobbyCommand' as Host, instead.")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class CloseLobbyCommand
{
    [ProtoMember(1)]
    public string LobbyId { get; set; }
}
