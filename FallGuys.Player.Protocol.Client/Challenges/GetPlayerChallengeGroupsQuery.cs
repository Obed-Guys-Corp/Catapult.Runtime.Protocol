using System;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_GetPlayerChallengeGroupsQuery_V1")]
public class GetPlayerChallengeGroupsQuery
{
	[ProtoMember(1)]
	[Obsolete("No longer used")]
	public string? EpisodeId { get; set; }
}
