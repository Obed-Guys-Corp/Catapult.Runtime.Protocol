using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_ConfigureEmotesCommand_V1")]
public class ConfigureEmotesCommand
{
	[ProtoMember(1)]
	public Dictionary<int, string>? Slots { get; set; }

	[ProtoMember(2)]
	public string? ScreenId { get; set; }
}
