using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace Catapult.Services.Gateway.Protocol.Client;

[ProtoContract(Name = "Catapult_Gateway_LogAnalyticsEventsCommand_V1")]
[Authorize(AllowAnonymous = true)]
public class LogAnalyticsEventsCommand
{
	[ProtoIgnore]
	private List<LogAnalyticsEventCommand>? _analyticsEventCommands;

	[ProtoMember(1)]
	public List<LogAnalyticsEventCommand> AnalyticsEventCommands
	{
		get
		{
			return _analyticsEventCommands ?? (_analyticsEventCommands = new List<LogAnalyticsEventCommand>());
		}
		set
		{
			_analyticsEventCommands = value;
		}
	}
}
