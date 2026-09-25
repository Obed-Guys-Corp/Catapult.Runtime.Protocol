using Catapult.Protocol;
using ProtoBuf;
using System;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking.Identity;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Gateway_Matchmaking_GetMatchmakingIdentityQuery_V1")]
[Obsolete("Use the fn matchmaker")]
public class GetMatchmakingIdentityQuery
{
}
