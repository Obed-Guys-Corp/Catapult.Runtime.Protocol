using Catapult.Protocol;
using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Lobby.Protocol.Client.SelectShows;

[ProtoContract(Name = "FallGuys_Lobby_SelectShowsCommand_V1")]
[Obsolete("Use SelectNextShowCommand instead")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class SelectShowsCommand
{
    [ProtoMember(1)]
    public string? LobbyId { get; set; }

    [ProtoMember(2)]
    public List<string> ShowIds { get; set; } = null!;
}
