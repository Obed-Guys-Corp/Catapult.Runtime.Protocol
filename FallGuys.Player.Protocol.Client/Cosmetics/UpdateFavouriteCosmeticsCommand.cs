using System.Collections.Generic;
using Catapult.Protocol;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Cosmetics;

[Authorize(Roles = new string[] { CoreRoles.User })]
[ProtoContract(Name = "FallGuys_Player_UpdateFavouriteCosmeticsCommand_V1")]
public class UpdateFavouriteCosmeticsCommand
{
	private HashSet<string>? _favouriteCosmeticsAdded;

	private HashSet<string>? _favouriteCosmeticsRemoved;

	[ProtoMember(1)]
	public HashSet<string> FavouriteCosmeticsAdded
	{
		get
		{
			return _favouriteCosmeticsAdded ?? (_favouriteCosmeticsAdded = new HashSet<string>());
		}
		set
		{
			_favouriteCosmeticsAdded = value;
		}
	}

	[ProtoMember(2)]
	public HashSet<string> FavouriteCosmeticsRemoved
	{
		get
		{
			return _favouriteCosmeticsRemoved ?? (_favouriteCosmeticsRemoved = new HashSet<string>());
		}
		set
		{
			_favouriteCosmeticsRemoved = value;
		}
	}
}
