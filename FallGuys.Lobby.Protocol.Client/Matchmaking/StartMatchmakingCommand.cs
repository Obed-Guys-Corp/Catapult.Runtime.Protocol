using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Matchmaking;

[ProtoContract(Name = "FallGuys_Lobby_StartMatchmakingCommand_V1")]
[Authorize(Roles = new string[] { "User" })]
public class StartMatchmakingCommand
{
	[ProtoMember(1)]
	public string LobbyId { get; set; }

	[ProtoMember(2)]
	public List<string> ShowIds { get; set; }
}
