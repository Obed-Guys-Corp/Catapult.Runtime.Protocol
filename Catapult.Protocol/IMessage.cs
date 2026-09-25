using System.Collections.Generic;

namespace Catapult.Protocol;

public interface IMessage
{
	List<MessageHeader> Headers { get; }
}
