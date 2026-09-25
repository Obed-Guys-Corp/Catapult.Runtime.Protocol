using Catapult.Protocol.Headers;

namespace Catapult.Protocol;

public static class MessageExtensions
{
    public static string GetRequestId(this Message message)
    {
        return message.GetHeader<OperationHeader>()?.RequestId.ToString() ?? "(empty)";
    }

    public static string GetCorrelationId(this Message message)
    {
        return message.GetHeader<CorrelationHeader>()?.ActivityId.ToString() ?? "(empty)";
    }

    [Obsolete("Read the UserId from the UserContext instead")]
    public static string GetUserId(this Message message)
    {
        return message.GetHeader<UserSessionHeader>()?.UserId ?? "(empty)";
    }
}
