using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Settings;

[ProtoContract(Name = "FallGuys_Player_ConfigureSettingsCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class ConfigureSettingsCommand
{
    [ProtoMember(1)]
    public Dictionary<string, string> Values { get; set; } = null!;
}
