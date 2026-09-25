using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace Catapult.Services.Login.Protocol.Client.Requests;

[Authorize(AllowAnonymous = true)]
[ProtoContract(Name = "Catapult_Login_AddIdentityRequest_V1")]
public class AddIdentityRequest
{
    [ProtoMember(1)]
    public string? ExistingIdentityType { get; set; }

    [ProtoMember(2)]
    public string? ExistingIdentityToken { get; set; }

    [ProtoMember(3)]
    public Dictionary<string, string> ExistingIdentityProperties { get; set; } = null!;

    [ProtoMember(4)]
    public string? NewIdentityType { get; set; }

    [ProtoMember(5)]
    public string? NewIdentityToken { get; set; }

    [ProtoMember(6)]
    public Dictionary<string, string> NewIdentityProperties { get; set; } = null!;
}
