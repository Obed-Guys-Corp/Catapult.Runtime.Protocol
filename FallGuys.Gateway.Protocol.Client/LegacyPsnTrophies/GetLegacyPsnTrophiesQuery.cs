using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.LegacyPsnTrophies;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Gateway_GetLegacyPsnTrophiesQuery_V1")]
public class GetLegacyPsnTrophiesQuery
{
	[ProtoMember(1)]
	public string AuthCode { get; set; }

	[ProtoMember(2)]
	public int? PsnEnvironment { get; set; }
}
