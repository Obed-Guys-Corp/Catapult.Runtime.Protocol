using Catapult.Protocol;
using FallGuys.Common.Debug.Protocol.Client;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Debug;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Gateway_GenerateDebugStringCommand_V1")]
[DebugMessage]
public class GenerateDebugStringCommand
{
	[ProtoMember(1)]
	public int Size { get; set; }
}
