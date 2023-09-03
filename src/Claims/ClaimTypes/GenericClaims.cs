/*
 * GenericUriStrings.cs
 *
 *   Created: 2022-12-17-07:06:21
 *   Modified: 2022-12-17-07:06:21
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity;

public abstract class OtherClaimType : ClaimType
{

}


/// <summary>The URI for an unknown user login provider</summary>
/// <value>urn:users:login:provider:none</value>
public class UnknownLoginProvider : OtherClaimType, IClaimType, IClaimTypeOrValueType
{
    /// <value>urn:users:login:provider:none</value>
    public const string UriString = "urn:users:login:provider:none";
    /// <value>UnknownLoginProvider</value>
    public const string Name = "UnknownLoginProvider";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IClaimTypeOrValueType.Name => Name;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IClaimTypeOrValueType.UriString => UriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
}

/// <summary>The URI for a login provider</summary>
/// <value>urn:users:login:provider:{provider}</value>
public class LoginProviderPattern : OtherClaimType, IClaimType, IClaimTypeOrValueType
{
    /// <value>urn:users:login:provider:{0}</value>
    public const string UriString = "urn:users:login:provider:{0}";
    /// <value>LoginProviderPattern</value>
    public const string Name = "LoginProviderPattern";
    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IClaimTypeOrValueType.Name => Name;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IClaimTypeOrValueType.UriString => UriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
}

/// <summary>The URI for a security stamp</summary>
/// <value>urn:identity:securitystamp</value>
public class SecurityStamp : OtherClaimType, IClaimType, IClaimTypeOrValueType
{
    /// <value>urn:identity:securitystamp</value>
    public const string UriString = "urn:identity:securitystamp";
    /// <value>SecurityStamp</value>
    public const string Name = "SecurityStamp";
    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IClaimTypeOrValueType.Name => Name;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IClaimTypeOrValueType.UriString => UriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
}

/// <summary>The URI for a generic claim type</summary>
/// <value>urn:identity:claim:generic:{0}</value>
public class GenericClaimTypePattern : OtherClaimType, IClaimType, IClaimTypeOrValueType
{
    /// <value>urn:identity:claim:custom:{0}</value>
    public const string UriString = "urn:identity:claim:custom:{0}";
    /// <value>GenericClaimTypePattern</value>
    public const string Name = "GenericClaimTypePattern";
    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IClaimTypeOrValueType.Name => Name;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IClaimTypeOrValueType.UriString => UriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
}

/// <summary>The URI for a generic claims issuer</summary>
/// <value>urn:identity:claim:issuer:generic:{0}</value>
public class GenericClaimsIssuerTypePattern : OtherClaimType, IClaimType
{
    /// <value>urn:identity:claim:issuer:custom:{0}</value>
    public const string UriString = "urn:identity:claim:issuer:custom:{0}";
    /// <value>GenericClaimsIssuerTypePattern</value>
    public const string Name = "GenericClaimsIssuerTypePattern";
    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IClaimTypeOrValueType.Name => Name;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IClaimTypeOrValueType.UriString => UriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
}

/// <summary>The URI for a generic claims value type</summary>
/// <value>urn:identity:claim:custom</value>
public class Custom : OtherClaimType, IClaimType, IClaimTypeOrValueType
{
    /// <value>urn:identity:claim:custom</value>
    public const string UriString = "urn:identity:claim:custom";
    /// <value>Custom</value>
    public const string Name = "Custom";
    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IClaimTypeOrValueType.Name => Name;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IClaimTypeOrValueType.UriString => UriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
}

/// <summary>The URI for a generic claims value type</summary>
/// <value>urn:identity:claim:unknown</value>
public class Unknown : OtherClaimType, IClaimType, IClaimTypeOrValueType
{
    /// <value>urn:identity:claim:unknown</value>
    public const string UriString = "urn:identity:claim:unknown";
    /// <value>Unknown</value>
    public const string Name = "Unknown";
    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IClaimTypeOrValueType.Name => Name;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IClaimTypeOrValueType.UriString => UriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
}
