using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Settings;

[ProtoContract(Name = "FallGuys_Player_GetAllSettingsQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetAllSettingsQuery
{
}
