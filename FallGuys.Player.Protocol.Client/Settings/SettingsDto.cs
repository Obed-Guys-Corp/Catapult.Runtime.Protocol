using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Settings;

[ProtoContract(Name = "FallGuys_Player_SettingsDto_V1")]
public class SettingsDto
{
    [ProtoMember(1)]
    public Dictionary<string, string> Values { get; set; }
}
