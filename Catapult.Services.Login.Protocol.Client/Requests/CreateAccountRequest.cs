using Catapult.Protocol;
using ProtoBuf;
using System.Collections.Generic;

namespace Catapult.Services.Login.Protocol.Client.Requests;

[ProtoContract(Name = "Catapult_Login_CreateAccountRequest_V1")]
[Authorize(AllowAnonymous = true)]
public class CreateAccountRequest
{
    private Dictionary<string, string>? _properties;

    [ProtoMember(1)]
    public string? IdentityType { get; set; }

    [ProtoMember(2)]
    public string? IdentityToken { get; set; }

    [ProtoMember(3)]
    public Dictionary<string, string> Properties { get; set; }
}
