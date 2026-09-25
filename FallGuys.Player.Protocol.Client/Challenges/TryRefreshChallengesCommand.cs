using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_TryRefreshChallengesCommand_V1")]
public class TryRefreshChallengesCommand
{
}
