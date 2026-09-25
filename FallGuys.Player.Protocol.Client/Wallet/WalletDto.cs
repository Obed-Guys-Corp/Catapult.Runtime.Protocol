using System;
using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Wallet;

[ProtoContract(Name = "FallGuys_WalletDto_V1")]
public class WalletDto
{
	private Dictionary<string, int>? _currencyAmounts;

	[ProtoMember(1)]
	public int Kudos { get; set; }

	[ProtoMember(2)]
	public int Crowns { get; set; }

	[ProtoMember(3)]
	public int CrownShards { get; set; }

	[ProtoMember(4)]
	[Obsolete("No longer used")]
	public int GemsPurchased { get; set; }

	[ProtoMember(5)]
	public int GemsGranted { get; set; }

	[ProtoMember(6)]
	public Dictionary<string, int> CurrencyAmounts
	{
		get
		{
			return _currencyAmounts ?? (_currencyAmounts = new Dictionary<string, int>());
		}
		set
		{
			_currencyAmounts = value;
		}
	}
}
