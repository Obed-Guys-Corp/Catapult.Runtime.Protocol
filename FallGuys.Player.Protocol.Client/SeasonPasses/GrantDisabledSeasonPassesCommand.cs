using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.SeasonPasses;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_GrantDisabledSeasonPassesCommand_V1")]
public class GrantDisabledSeasonPassesCommand
{
}
