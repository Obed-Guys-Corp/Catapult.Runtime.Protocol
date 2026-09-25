using System.Collections.Generic;
using ProtoBuf;

namespace FallGuys.Player.Protocol.Client.Wallet;

[ProtoContract(Name = "FallGuys_AdminPlayerWalletDto_V1")]
public class AdminPlayerWalletDto
{
	private Dictionary<string, PlatformPocketDto>? _platformsPockets;

	[ProtoMember(1)]
	public int Kudos { get; set; }

	[ProtoMember(2)]
	public int Crowns { get; set; }

	[ProtoMember(3)]
	public int CrownShards { get; set; }

	[ProtoMember(4)]
	public int Gems { get; set; }

	[ProtoMember(5)]
	public bool IsWalletMigrationCompleted { get; set; }

	[ProtoMember(6)]
	public Dictionary<string, PlatformPocketDto> PlatformPockets
	{
		get
		{
			return _platformsPockets ?? (_platformsPockets = new Dictionary<string, PlatformPocketDto>());
		}
		set
		{
			_platformsPockets = value;
		}
	}

	[ProtoMember(7)]
	public bool IsCrownToKudosConversionCompleted { get; set; }
}
