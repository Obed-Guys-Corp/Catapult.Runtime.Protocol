using System;
using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking.Fn;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Gateway_GetPlayerMatchmakingTokenQuery_V1")]
public class GetPlayerMatchmakingTokenQuery
{
	private List<string>? _showIds;

	private List<string>? _otherPartyMemberIds;

	private List<PartyMemberDto>? _otherPartyMembers;

	[ProtoMember(1)]
	public List<string> ShowIds
	{
		get
		{
			return _showIds ?? (_showIds = new List<string>());
		}
		set
		{
			_showIds = value;
		}
	}

	[ProtoMember(2)]
	public string? PoolId { get; set; }

	[Obsolete("Please use OtherPartyMembers")]
	[ProtoMember(3)]
	public List<string> OtherPartyMemberIds
	{
		get
		{
			return _otherPartyMemberIds ?? (_otherPartyMemberIds = new List<string>());
		}
		set
		{
			_otherPartyMemberIds = value;
		}
	}

	[ProtoMember(4)]
	public bool CrossplayEnabled { get; set; }

	[ProtoMember(6)]
	public string? RegionId { get; set; }

	[ProtoMember(7)]
	public string? ProfileId { get; set; }

	[ProtoMember(8)]
	public List<PartyMemberDto> OtherPartyMembers
	{
		get
		{
			return _otherPartyMembers ?? (_otherPartyMembers = new List<PartyMemberDto>());
		}
		set
		{
			_otherPartyMembers = value;
		}
	}
}
