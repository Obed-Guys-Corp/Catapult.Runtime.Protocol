using System;
using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Challenges;

[ProtoContract(Name = "FallGuys_Player_DebugResetChallengeProgressCommand_V1")]
[Authorize(Roles = new string[] { "User" })]
[DebugMessage]
[Obsolete("Use DebugResetChallengeProgressByIdCommand")]
public class DebugResetChallengeProgressCommand
{
	[ProtoMember(1)]
	public int Slot { get; set; }
}
