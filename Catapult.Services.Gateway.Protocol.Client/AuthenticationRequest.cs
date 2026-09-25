using Catapult.Protocol;
using ProtoBuf;
using System;

namespace Catapult.Services.Gateway.Protocol.Client;

[ProtoContract(Name = "Catapult_Gateway_AuthenticationRequest_V1")]
[Authorize(AllowAnonymous = true)]
public class AuthenticationRequest
{
    [ProtoMember(1)]
    public string? Token { get; set; }

    [ProtoMember(2)]
    public string? ContentEtag { get; set; }

    [Obsolete("This is no longer checked by services. Protocol versions usually remain backwards compatible.")]
    [ProtoMember(3)]
    public string? ProtocolVersion { get; set; }

    [Obsolete("This flag is no longer used")]
    [ProtoMember(4)]
    public bool ContinueSession { get; set; }
}
