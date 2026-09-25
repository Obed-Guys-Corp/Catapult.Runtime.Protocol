using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace Catapult.Services.Gateway.Protocol.Client;

[ProtoContract(Name = "Catapult_Gateway_LogAnalyticsEventsCommand_V1")]
[Authorize(AllowAnonymous = true)]
public class LogAnalyticsEventsCommand
{
    [ProtoMember(1)]
    public List<LogAnalyticsEventCommand> AnalyticsEventCommands { get; set; } = null!;
}
