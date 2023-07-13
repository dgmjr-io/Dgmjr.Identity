extern alias primitives;
/*
 * ClaimTypeUris.cs
 *
 *   Created: 2022-11-23-08:41:50
 *   Modified: 2022-11-23-08:41:51
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
namespace Dgmjr.Identity.Claims;

using primitives::System.Net.Mail;
using Dgmjr.Identity.Claims.Abstractions;

/// <summary>Definition: (mail in inetOrgPerson) Preferred address for the “To:” field of email to be sent to the subject, usually of the form @. According to inetOrgPerson using RFC 1274: “This attribute type specifies an electronic mailbox attribute following the syntax specified in RFC 822.”</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress</value>
public sealed class Email : Soap2005ClaimBaseType<Email, EmailAddress>
{
    static readonly string[] _synonyms = new string[] { "urn:oid:0.9.2342.19200300.100.1.3", "ldap:mail" };

    /// <summary>The singleton instance of the <see cref="Email" /> class.</summary>
    /// <returns>an instance of the <see cref="Email" /> class</returns>
    public static readonly IClaimType Instance = new Email();
    private Email() { }
    /// <value>emailaddress</value>
    public const string _Name = "emailaddress";
    public const string _Description = "Definition: (sn in RFC 2256) Surname or family name of a subject. According to RFC 2256: “This is the X.500 surname attribute which contains the family name of a person.”";
    public override string[] Synonyms
    {
        get => base.Synonyms.Concat(_synonyms).ToArray();
        init => base.Synonyms = value;
    }

    /// <inheritdoc cref="_Name" />
    public override string Name => _Name;

    public override string LongUriString => base.LongUriString;

    EmailAddress IClaimTypeWithValue<EmailAddress>.Value { get; set; }

    string IClaimTypeWithValue<string>.Value { get => ((IClaimTypeWithValue<EmailAddress>)this).Value; set => ((IClaimTypeWithValue<EmailAddress>)this).Value = EmailAddress.From(value); }
}
