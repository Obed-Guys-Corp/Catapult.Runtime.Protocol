using Catapult.Protocol.Custom.Attributes;
using Catapult.Protocol.Custom.Serializers;
using ProtoBuf;
using System.Text;

namespace Catapult.Protocol.Internal;

[ProtoContract(Name = "Catapult_ErrorMessage_V1")]
public sealed class ErrorMessage : Message, IResult, IContainStatusCode
{
	[ProtoIgnore]
	private ErrorDescription? _error;

	[ProtoMember(1)]
	public ErrorDescription? Error
	{
		get => _error ??= new ErrorDescription();
        set => _error = value;
    }

	[ProtoIgnore]
	public bool IsSuccess => false;

	public ErrorMessage()
	{
	}

	public ErrorMessage(ErrorDescription error)
	{
		Error = error;
	}

	public int GetErrorCode()
	{
		return Error?.ErrorCode ?? 0;
	}

	public override string ToString()
	{
		if (Error == null) return string.Empty;	

		StringBuilder stringBuilder = new(base.ToString());
		stringBuilder.AppendLine(GetTypeName());
		if (Error.ErrorCode != 0 || Error.Message != null)
		{
			stringBuilder.AppendLine("Error:");
			stringBuilder.AppendLine(Error.ToString());
		}
		return stringBuilder.ToString();
	}
}
