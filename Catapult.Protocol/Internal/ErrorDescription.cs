using Newtonsoft.Json;
using ProtoBuf;
using System.Globalization;
using System.Text;

namespace Catapult.Protocol.Internal;

[ProtoContract(Name = "Catapult_ErrorDescription_V1")]
public class ErrorDescription
{
    [JsonProperty("errorCode")]
    [ProtoMember(1)]
    public ushort StatusCode { get; set; }

    [JsonIgnore]
    [ProtoIgnore]
    public ushort ErrorCode
    {
        get => StatusCode;
        set => StatusCode = value;
    }

    [ProtoMember(2)]
    public string? ErrorString { get; set; }

    [ProtoMember(3)]
    public string? Message { get; set; }

    [ProtoMember(4)]
    public ErrorDetails? Details { get; set; }

    [ProtoIgnore]
    [JsonIgnore]
    public int ServerErrorCode => Details?.ServerCode ?? 0;

    public ErrorDescription()
    {
    }

    public ErrorDescription(CatapultStatusCode statusCode, string message, Enum serverCode, string? technicalMessage = null)
    {
        Details = new ErrorDetails(serverCode, technicalMessage);
        ErrorCode = Convert.ToUInt16(statusCode, NumberFormatInfo.InvariantInfo);
        ErrorString = statusCode.ToString();
        Message = message;
    }

    public ErrorDescription(CatapultStatusCode statusCode, string message, ErrorDetails details)
    {
        ErrorCode = Convert.ToUInt16(statusCode, NumberFormatInfo.InvariantInfo);
        ErrorString = statusCode.ToString();
        Message = message;
        Details = details;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine(string.Format("{0}: {1}", "ErrorCode", ErrorCode));
        stringBuilder.AppendLine("ErrorString: " + ErrorString);
        stringBuilder.AppendLine("Message: " + Message);
        if (Details != null)
        {
            stringBuilder.AppendLine(Details.ToString());
        }
        return stringBuilder.ToString();
    }
}
