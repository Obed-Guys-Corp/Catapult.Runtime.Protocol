using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Gateway.Protocol.Client.Matchmaking.Fn;

[ProtoContract(Name = "FallGuys_Gateway_GetPlayerMatchmakingTokenQuery_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class GetPlayerMatchmakingTokenQuery
{
    private List<string>? _showIds;
    private List<PartyMemberDto>? _otherPartyMembers;

    [ProtoMember(1)]
    public List<string> ShowIds { get; set; }

    [ProtoMember(2)]
    public string? PoolId { get; set; }

    [ProtoMember(4)]
    public bool CrossplayEnabled { get; set; }

    [ProtoMember(6)]
    public string? RegionId { get; set; }

    [ProtoMember(7)]
    public string? ProfileId { get; set; }

    [ProtoMember(8)]
    public List<PartyMemberDto> OtherPartyMembers { get; set; }

    [ProtoMember(9)]
    public string? PartyLeaderAccountId { get; set; }
}
