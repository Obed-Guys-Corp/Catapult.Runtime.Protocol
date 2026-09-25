using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Profile;

[ProtoContract(Name = "FallGuys_Player_GetRandomNameQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetRandomNameQuery
{
	[ProtoMember(1)]
	public PlayerNameLanguage Language { get; set; }
}
