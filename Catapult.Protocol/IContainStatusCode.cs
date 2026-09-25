namespace Catapult.Protocol;

public interface IContainStatusCode
{
	bool IsSuccess { get; }

	int GetErrorCode();
}
