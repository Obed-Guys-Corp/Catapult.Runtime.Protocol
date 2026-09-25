using System;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking.Identity;

[ProtoContract(Name = "FallGuys_Gateway_Matchmaking_GetMatchmakingIdentityQuery_V1")]
[Authorize(Roles = new string[] { "User" })]
[Obsolete("Use the fn matchmaker")]
public class GetMatchmakingIdentityQuery
{
}
