using Catapult.Protocol;
using FallGuys.Lobby.Protocol.Client.CreateLobby.Modes.Debug;
using FallGuys.Lobby.Protocol.Client.CreateLobby.Modes.Private;
using FallGuys.Lobby.Protocol.Client.CreateLobby.Modes.Private.Show.CmsShow;
using ProtoBuf;

namespace FallGuys.Lobby.Protocol.Client.SelectShows;

[ProtoContract(Name = "FallGuys_Lobby_Client_SelectNextShowCommand_V1")]
[Authorize(Roles = new string[] { CoreRoles.User })]
public class SelectNextShowCommand
{
	private PrivateLobbyConfigDto? _privateLobbyConfig;

	[ProtoMember(1)]
	public string? LobbyId { get; set; }

	[ProtoMember(4)]
	public LobbyType LobbyType { get; set; } = LobbyType.Private;

	[ProtoMember(2)]
	public string? ShowId { get; set; }

	[ProtoMember(3)]
	public DebugLobbyConfigDto? DebugLobbyConfig { get; set; }

	[ProtoMember(5)]
	public PrivateLobbyConfigDto? PrivateLobbyConfig
	{
		get
		{
			if (LobbyType != LobbyType.Private)
			{
				return null;
			}
			if (_privateLobbyConfig != null)
			{
				return _privateLobbyConfig;
			}
			return new PrivateLobbyConfigDto
			{
				ShowType = LobbyShowType.Cms,
				CmsShowConfig = new CmsShowConfigDto
				{
					ShowContentId = ShowId
				}
			};
		}
		set
		{
			_privateLobbyConfig = value;
		}
	}
}
