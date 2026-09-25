using System;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges;

[ProtoContract(Name = "FallGuys_Player_GetChallengesQuery_V1")]
[Authorize(Roles = new string[] { "User" })]
[Obsolete("Use GetPlayerChallengeGroupQuery instead")]
public class GetChallengesQuery
{
}
