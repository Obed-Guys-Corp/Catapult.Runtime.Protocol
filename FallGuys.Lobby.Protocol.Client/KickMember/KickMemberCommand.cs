using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.KickMember;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Lobby_KickMemberCommand_V1")]
public class KickMemberCommand
{
	[ProtoMember(1)]
	public string? LobbyId { get; set; }

	[ProtoMember(2)]
	public string? MemberId { get; set; }
}
