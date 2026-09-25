using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace Catapult.Services.Login.Protocol.Client.Requests;

[Authorize(AllowAnonymous = true)]
[ProtoContract(Name = "Catapult_Login_RemoveIdentityRequest_V1")]
public class RemoveIdentityRequest
{
    private Dictionary<string, string>? _identityProperties;

    [ProtoMember(1)]
    public string? IdentityType { get; set; }

    [ProtoMember(2)]
    public string? IdentityToken { get; set; }

    [ProtoMember(3)]
    public Dictionary<string, string> IdentityProperties { get; set; }

    [ProtoMember(4)]
    public string? IdentityTypeToRemove { get; set; }

    [ProtoMember(5)]
    public string? IdentityIdToRemove { get; set; }
}
