using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.Challenges;

[Obsolete("Use DebugRefreshChallengeGroupsCommand")]
[DebugMessage]
[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_DebugRefreshAllChallengesCommand_V1")]
public class DebugRefreshAllChallengesCommand
{
}
