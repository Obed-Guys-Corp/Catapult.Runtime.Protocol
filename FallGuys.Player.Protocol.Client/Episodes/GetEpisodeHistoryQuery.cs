using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Episodes;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_GetEpisodeHistoryQuery_V1")]
public class GetEpisodeHistoryQuery
{
}
