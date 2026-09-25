using ProtoBuf;
using System.Globalization;

namespace Catapult.Protocol;

[ProtoContract(Name = "Catapult_DateTimeOffsetSurrogate_V1")]
public class DateTimeOffsetSurrogate
{
    [ProtoMember(1)]
    public string? DateTimeOffsetString { get; set; }

    public static implicit operator DateTimeOffsetSurrogate(DateTimeOffset source)
    {
        return new DateTimeOffsetSurrogate
        {
            DateTimeOffsetString = source.ToString("o")
        };
    }

    public static implicit operator DateTimeOffset(DateTimeOffsetSurrogate source)
    {
        try
        {
            return DateTimeOffset.Parse(source.DateTimeOffsetString!, null, DateTimeStyles.RoundtripKind);
        }
        catch (Exception innerException)
        {
            throw new ArgumentException("Unable to parse date time offset value: " + source.DateTimeOffsetString, innerException);
        }
    }
}
