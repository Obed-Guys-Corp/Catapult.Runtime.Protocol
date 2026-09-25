using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.PlayerComplaints;

[ProtoContract(Name = "FallGuys_Gateway_MakeComplaintCommand_V1")]
[Authorize(Roles = new string[] { "User" })]
public class MakeComplaintCommand
{
	[ProtoMember(1)]
	public string ComplaintType { get; set; }

	[ProtoMember(2)]
	public string ReportedId { get; set; }
}
