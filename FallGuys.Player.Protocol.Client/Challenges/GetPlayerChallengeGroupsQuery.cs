using Catapult.Protocol;
using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.Challenges;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_GetPlayerChallengeGroupsQuery_V1")]
public class GetPlayerChallengeGroupsQuery
{
    [Obsolete("No longer used")]
    [ProtoMember(1)]
    public string? EpisodeId { get; set; }
}
