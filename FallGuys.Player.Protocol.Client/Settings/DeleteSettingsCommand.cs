using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Settings;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_DeleteSettingsCommand_V1")]
public class DeleteSettingsCommand
{
	[ProtoMember(1)]
	public List<string> Keys { get; set; }
}
