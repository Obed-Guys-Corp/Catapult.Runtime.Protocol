using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Settings;

[ProtoContract(Name = "FallGuys_Player_DeleteSettingsCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class DeleteSettingsCommand
{
    [ProtoMember(1)]
    public List<string> Keys { get; set; } = null!;
}
