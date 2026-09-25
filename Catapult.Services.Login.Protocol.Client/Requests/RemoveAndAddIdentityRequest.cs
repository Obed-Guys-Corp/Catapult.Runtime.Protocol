using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace Catapult.Services.Login.Protocol.Client.Requests;

[ProtoContract(Name = "Catapult_Login_RemoveAndAddIdentityRequest_V1")]
[Authorize(AllowAnonymous = true)]
public class RemoveAndAddIdentityRequest
{
    private Dictionary<string, string>? _addIdentityProperties;
    private Dictionary<string, string>? _removeIdentityProperties;

    [ProtoMember(1)]
    public string? RemoveIdentityType { get; set; }

    [ProtoMember(2)]
    public string? RemoveIdentityToken { get; set; }

    [ProtoMember(3)]
    public Dictionary<string, string> RemoveIdentityProperties { get; set; }

    [ProtoMember(4)]
    public string? AddIdentityType { get; set; }

    [ProtoMember(5)]
    public string? AddIdentityToken { get; set; }

    [ProtoMember(6)]
    public Dictionary<string, string> AddIdentityProperties { get; set; }
}
