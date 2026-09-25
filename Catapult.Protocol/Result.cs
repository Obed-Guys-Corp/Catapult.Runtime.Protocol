using Catapult.Protocol.Custom.Attributes;
using Catapult.Protocol.Internal;
using ProtoBuf;
using System.Globalization;
using System.Text;

namespace Catapult.Protocol;

[ProtoContract(Name = "Catapult_Result_V1")]
public class Result : Message, IResult, IContainStatusCode
{
	[ProtoMember(1)]
	public ErrorDescription? Error { get; set; }

	public bool IsSuccess => Error == null;

	public static Result Ok()
	{
		return new Result();
	}

	public static Task<Result> OkTask()
	{
		return Task.FromResult(new Result());
	}

	public static Result<T> Ok<T>(T body)
	{
		return new Result<T>(body);
	}

	public static Task<Result<T>> OkTask<T>(T body)
	{
		return Task.FromResult(new Result<T>(body));
	}

	public static Result<T> Ok<T>(CatapultStatusCode statusCode, T body)
	{
		return new Result<T>(body)
		{
			Error = new ErrorDescription
			{
				ErrorCode = Convert.ToUInt16(statusCode, NumberFormatInfo.InvariantInfo)
			}
		};
	}

	public static Result BadRequest(string message, Enum errorCode)
	{
		return Fail(CatapultStatusCode.BadRequest, message, errorCode);
	}

	public static Result NotFound(Enum errorCode, string message)
	{
		return Fail(CatapultStatusCode.NotFound, message, errorCode);
	}

	public static Result Fail(CatapultStatusCode statusCode, string message, Enum errorCode, string? technicalMessage = null)
	{
		return new Result(new ErrorDescription(statusCode, message, errorCode, technicalMessage));
	}

	public static Result Fail(ErrorMessage errorMessage)
	{
		return new Result(errorMessage.Error);
	}

	public Result()
	{
	}

	public Result(ErrorDescription? error)
	{
		Error = error;
	}

	public int GetErrorCode()
	{
		if (!IsSuccess)
			return Error!.ErrorCode;

		return 200;
	}

	public static implicit operator Result(ErrorDescription error)
	{
		return new Result(error);
	}

	public static implicit operator Task<Result>(Result result)
	{
		return Task.FromResult(result);
	}
}

[ProtoContract(Name = "Catapult_TResult_V1")]
public sealed class Result<TResultMessage> : Message, IResult, IContainStatusCode
{
	[ProtoMember(1)]
	public TResultMessage? Body { get; set; }
    [ProtoMember(2)]
	public ErrorDescription? Error { get; set; }

	public bool IsSuccess => Error == null;

	public Result(TResultMessage msg)
	{
		Body = msg;
	}

	public Result(ErrorDescription error)
	{
		Error = error;
	}

    public Result()
	{
	}

	public override string GetTypeName()
	{
		return "Result<" + typeof(TResultMessage).Name + ">";
	}

	public bool IsErrorCode(Enum errorCode)
	{
		if (!IsSuccess)
			return Error!.ErrorCode == Convert.ToUInt16(errorCode, NumberFormatInfo.InvariantInfo);

		return false;
	}

	public bool IsErrorCode(ushort errorCode)
	{
		if (!IsSuccess)
			return Error!.ErrorCode == errorCode;

		return false;
	}

	public int GetErrorCode()
	{
		if (!IsSuccess)
			return Error!.ErrorCode;

		return 200;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new(base.ToString());
		if (Error != null)
		{
			stringBuilder.AppendLine(" Error:");
			stringBuilder.AppendLine(Error.ToString());
		}
		if (Body != null)
		{
			stringBuilder.AppendLine(" Body:");
			stringBuilder.AppendLine(Body.ToString());
		}
		return stringBuilder.ToString();
	}

	public static implicit operator Result<TResultMessage>(Result result)
	{
		return new Result<TResultMessage>(result.Error!);
	}

	public static implicit operator Result<TResultMessage>(TResultMessage body)
	{
		return new Result<TResultMessage>(body);
	}

	public static implicit operator Result<TResultMessage>(ErrorDescription error)
	{
		return new Result<TResultMessage>(error);
	}

	public static implicit operator Task<Result<TResultMessage>>(Result<TResultMessage> result)
	{
		return Task.FromResult(result);
	}
}
