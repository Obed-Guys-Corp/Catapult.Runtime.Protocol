using ProtoBuf;

namespace Catapult.Protocol;

[Authorize(AllowAnonymous = true)]
[ProtoContract(Name = "Catapult_Gateway_KeepAliveMessage_V1")]
public class KeepAliveMessage : Message
{
}
