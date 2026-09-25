using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Challenges;

[ProtoContract(Name = "FallGuys_Player_DebugRefreshChallengeGroupsCommand_V1")]
[DebugMessage]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class DebugRefreshChallengeGroupsCommand
{
    [ProtoIgnore]
    private List<string>? _challengeGroupIds;

    [ProtoMember(1)]
    public List<string> ChallengeGroupIds { get; set; }
}
