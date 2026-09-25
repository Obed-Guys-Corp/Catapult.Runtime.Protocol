using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Gateway.Protocol.Client;

[Authorize(AllowAnonymous = true)]
[ProtoContract(Name = "Catapult_Gateway_TimestampRequest_V1")]
public class TimestampRequest
{
}
