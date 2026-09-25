using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.SeasonPasses;

[ProtoContract(Name = "FallGuys_Player_GrantDisabledSeasonPassesCommand_V1")]
[Authorize(Roles = new string[] { "User" })]
public class GrantDisabledSeasonPassesCommand
{
}
