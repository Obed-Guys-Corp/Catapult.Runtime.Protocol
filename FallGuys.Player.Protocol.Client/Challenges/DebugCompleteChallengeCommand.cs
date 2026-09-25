using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;
using System;

namespace FallGuys.Player.Protocol.Client.Challenges;

[Obsolete("Use DebugCompleteChallengeByIdCommand")]
[DebugMessage]
[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_DebugCompleteChallengeCommand_V1")]
public class DebugCompleteChallengeCommand
{
    [ProtoMember(1)]
    public int Slot { get; set; }
}
