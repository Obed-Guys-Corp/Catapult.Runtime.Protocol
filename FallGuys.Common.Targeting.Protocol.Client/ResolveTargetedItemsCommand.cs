using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Common.Targeting.Protocol.Client;

[ProtoContract(Name = "FallGuys_Player_ResolveTargetedItemsCommand_V1")]
[Authorize(Roles = new string[] { "User" })]
public class ResolveTargetedItemsCommand
{
	[ProtoIgnore]
	private List<string>? _contentIds;

	[ProtoMember(1)]
	public List<string> ContentIds
	{
		get
		{
			return _contentIds ?? (_contentIds = new List<string>());
		}
		set
		{
			_contentIds = value;
		}
	}
}
