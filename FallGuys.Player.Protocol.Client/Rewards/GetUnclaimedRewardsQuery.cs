using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Rewards;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_GetUnclaimedRewardsQuery_V1")]
public class GetUnclaimedRewardsQuery
{
}
