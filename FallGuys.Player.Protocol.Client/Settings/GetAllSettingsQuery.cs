using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Settings;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_GetAllSettingsQuery_V1")]
public class GetAllSettingsQuery
{
}
