using Catapult.Modules.Items.Protocol.Dtos;
using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.LiveEvents;

[ProtoContract(Name = "FallGuys_Player_LiveEventClaimResultDto_V1")]
public class LiveEventClaimResultDto
{
    [Obsolete("Use LiveEvents instead.")]
    [ProtoMember(1)]
    public LiveEventDto? LiveEvent { get; set; }

    [ProtoMember(2)]
    public List<ItemAddedDto> ItemsEarned { get; set; } = null!;

    [ProtoMember(3)]
    public LiveEventsDto? LiveEvents { get; set; }
}
