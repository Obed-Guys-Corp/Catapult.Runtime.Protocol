using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Settings;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_ConfigureSettingsCommand_V1")]
public class ConfigureSettingsCommand
{
	[ProtoMember(1)]
	public Dictionary<string, string> Values { get; set; }
}
