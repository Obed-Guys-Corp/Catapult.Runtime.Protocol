using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.PlayerLevel;

[ProtoContract(Name = "FallGuys_Player_GetUnclaimedPlayerLevelRewardsQuery_V1")]
[Authorize(Roles = new string[] { "User" })]
public class GetUnclaimedPlayerLevelRewardsQuery
{
}
