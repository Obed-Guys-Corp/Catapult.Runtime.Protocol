using ProtoBuf;
using System;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Profile;

[ProtoContract(Name = "FallGuys_Player_ProfileDto_V1")]
public class ProfileDto
{
    [ProtoMember(1)]
    public string Id { get; set; } = null!;

    [Obsolete("Use InternalAccountName and ExternalAccountName instead")]
    [ProtoMember(3)]
    public string PlayerName { get; set; } = null!;

    [ProtoMember(4)]
    public List<string> Tags { get; set; } = null!;

    [ProtoMember(5)]
    public PlayerNameDto InternalAccountName { get; set; } = null!;

    [ProtoMember(6)]
    public string ExternalAccountName { get; set; } = null!;

    [ProtoMember(7)]
    public bool IsBanned { get; set; }
}
