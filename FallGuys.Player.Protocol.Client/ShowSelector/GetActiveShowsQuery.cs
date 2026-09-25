using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.ShowSelector;

[Authorize(Roles = new string[] { "User" })]
[ProtoContract(Name = "FallGuys_Player_GetActiveShowsQuery_V1")]
public class GetActiveShowsQuery
{
}
