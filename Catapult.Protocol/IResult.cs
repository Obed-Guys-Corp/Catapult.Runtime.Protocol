using Catapult.Protocol.Internal;

namespace Catapult.Protocol;

public interface IResult : IContainStatusCode
{
	ErrorDescription? Error { get; set; }
}
