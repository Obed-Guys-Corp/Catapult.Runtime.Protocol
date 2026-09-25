using System;
using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Profile;

[ProtoContract(Name = "FallGuys_Player_ProfileDto_V1")]
public class ProfileDto
{
	[ProtoMember(1)]
	public string Id { get; set; }

	[ProtoMember(3)]
	[Obsolete("Use InternalAccountName and ExternalAccountName instead")]
	public string PlayerName { get; set; }

	[ProtoMember(4)]
	public List<string> Tags { get; set; }

	[ProtoMember(5)]
	public PlayerNameDto InternalAccountName { get; set; }

	[ProtoMember(6)]
	public string ExternalAccountName { get; set; }

	[ProtoMember(7)]
	public bool IsBanned { get; set; }
}
