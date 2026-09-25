using System;
using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges;

[ProtoContract(Name = "FallGuys_Player_DebugRefreshAllChallengesCommand_V1")]
[Obsolete("Use DebugRefreshChallengeGroupsCommand")]
[DebugMessage]
[Authorize(Roles = new string[] { "User" })]
public class DebugRefreshAllChallengesCommand
{
}
