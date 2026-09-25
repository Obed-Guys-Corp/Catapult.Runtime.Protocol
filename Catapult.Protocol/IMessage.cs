namespace Catapult.Protocol;

public interface IMessage
{
    List<MessageHeader> Headers { get; }
}
