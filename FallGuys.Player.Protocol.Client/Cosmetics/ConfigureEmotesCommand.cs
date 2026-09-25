using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[ProtoContract(Name = "FallGuys_Player_ConfigureEmotesCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class ConfigureEmotesCommand
{
    [ProtoMember(1)]
    public Dictionary<int, string>? Slots { get; set; }

    [ProtoMember(2)]
    public string? ScreenId { get; set; }
}
