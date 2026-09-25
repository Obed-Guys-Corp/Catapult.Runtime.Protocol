using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.Matchmaking;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Lobby_CancelMatchmakingCommand_V1")]
public class CancelMatchmakingCommand
{
	[ProtoMember(1)]
	public string LobbyId { get; set; }
}
