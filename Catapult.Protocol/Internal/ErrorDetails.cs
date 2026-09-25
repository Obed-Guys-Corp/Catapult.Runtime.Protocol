using ProtoBuf;
using System.Globalization;
using System.Text;

namespace Catapult.Protocol.Internal;

[ProtoContract(Name = "Catapult_ErrorDetails_V1")]
public class ErrorDetails
{
    [ProtoMember(1)]
    public int ServerCode { get; set; }

    [ProtoMember(2)]
    public string? Reason { get; set; }

    [ProtoMember(3)]
    public string? TechnicalMessage { get; set; }

    [ProtoMember(4)]
    public ErrorDescription? Inner { get; set; }

    public ErrorDetails()
    {
    }

    public ErrorDetails(Enum errorCode, string? technicalMessage = null)
    {
        ServerCode = Convert.ToInt32(errorCode, NumberFormatInfo.InvariantInfo);
        Reason = errorCode.ToString();
        TechnicalMessage = technicalMessage;
    }

    public ErrorDetails(int errorCode, string errorReason, string? technicalMessage = null)
    {
        ServerCode = errorCode;
        Reason = errorReason;
        TechnicalMessage = technicalMessage;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine(string.Format("{0}: {1}", "ServerCode", ServerCode));
        stringBuilder.AppendLine("Reason: " + Reason);
        stringBuilder.AppendLine("TechnicalMessage: " + TechnicalMessage);
        if (Inner != null)
        {
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Inner:");
            stringBuilder.AppendLine(Inner.ToString());
        }
        return stringBuilder.ToString();
    }
}
