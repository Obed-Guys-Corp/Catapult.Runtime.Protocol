namespace Catapult.Protocol;

public enum CatapultStatusCode : ushort
{
	Unknown = 0,
	Ok = 200,
	BadRequest = 400,
	Unauthorized = 401,
	Forbidden = 403,
	NotFound = 404,
	InvalidOperation = 405,
	SendFailed = 407,
	ConnectionFailed = 408,
	Conflict = 409,
	RateLimitExceeded = 429,
	SessionExpired = 440,
	ForceClientUpgrade = 470,
	ContentUpdateRequired = 471,
	StateSyncRequired = 480,
	AccountNotFound = 490,
	InternalServerError = 500,
	ConfigurationError = 501,
	TransientServerError = 502,
	ServiceUnavailable = 503,
	OperationTimeout = 504,
	MaintenanceModeEnabled = 505,
	Last = 999
}
