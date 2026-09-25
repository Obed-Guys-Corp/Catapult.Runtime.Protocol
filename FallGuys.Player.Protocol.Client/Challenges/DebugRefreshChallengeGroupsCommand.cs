using System.Collections.Generic;
using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges;

[DebugMessage]
[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_DebugRefreshChallengeGroupsCommand_V1")]
public class DebugRefreshChallengeGroupsCommand
{
	[ProtoIgnore]
	private List<string>? _challengeGroupIds;

	[ProtoMember(1)]
	public List<string> ChallengeGroupIds
	{
		get
		{
			return _challengeGroupIds ?? (_challengeGroupIds = new List<string>());
		}
		set
		{
			_challengeGroupIds = value;
		}
	}
}
