using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Profile;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_GetRandomNameQuery_V1")]
public class GetRandomNameQuery
{
    [ProtoMember(1)]
    public PlayerNameLanguage Language { get; set; }
}
