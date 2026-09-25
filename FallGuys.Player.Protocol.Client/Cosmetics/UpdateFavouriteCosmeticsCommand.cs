using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[ProtoContract(Name = "FallGuys_Player_UpdateFavouriteCosmeticsCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class UpdateFavouriteCosmeticsCommand
{
    private HashSet<string>? _favouriteCosmeticsAdded;
    private HashSet<string>? _favouriteCosmeticsRemoved;

    [ProtoMember(1)]
    public HashSet<string> FavouriteCosmeticsAdded { get; set; }

    [ProtoMember(2)]
    public HashSet<string> FavouriteCosmeticsRemoved { get; set; }
}
