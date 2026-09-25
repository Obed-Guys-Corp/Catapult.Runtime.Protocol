using Catapult.Protocol;
using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.Challenges;

[Authorize(Roles = new string[] { CoreRoles.User })]
[Obsolete("Use GetPlayerChallengeGroupQuery instead")]
[ProtoContract(Name = "FallGuys_Player_GetChallengesQuery_V1")]
public class GetChallengesQuery
{
}
