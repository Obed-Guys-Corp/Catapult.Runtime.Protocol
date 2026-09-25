using Catapult.Protocol.Headers;
using ProtoBuf;

namespace Catapult.Protocol;

[ProtoContract(Name = "Catapult_MessageHeader_V1")]
public class MessageHeader : IMessageHeader
{
}
