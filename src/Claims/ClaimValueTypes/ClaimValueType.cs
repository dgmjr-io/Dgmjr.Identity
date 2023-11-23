/*
 * ClaimType.cs
 *
 *   Created: 2023-08-29-04:37:49
 *   Modified: 2023-08-29-04:37:49
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity;

using System.Reflection;

using global::System;
using global::System.Security;

public partial record class ClaimValueType<TValue> : ClaimValueType, IClaimValueType<TValue>
{
    public new virtual TValue? Value
    {
        get => (TValue?)base.Value;
        set => base.Value = value;
    }

    string IHaveAName.Name => typeof(TValue).Name;

    public static implicit operator TValue(ClaimValueType<TValue> cvt) => cvt.Value;
}

public partial record class ClaimValueType : IdentityComponent, IClaimValueType
{
    public virtual bool Equals(IClaimValueType? other)
    {
        return other is not null && (ReferenceEquals(this, other) || Uri == other.Uri);
    }

    public object Value { get; set; }

    public virtual string DefaultStringValue => string.Empty;
    public virtual string ExampleStringValue => string.Empty;

    string IHaveAName.Name => string.Empty;

    public new virtual string UriString => "about:blank";
    public virtual string ShortUriString => "about:blank";
    public virtual uri Uri => UriString;
    public virtual uri ShortUri => ShortUriString;

    public static ClaimValueType FromUri(uri uri) => GetAll().First(ct => ct.Uri == uri);

    // public override bool Equals(object? other) => Equals(other as IClaimValueType);

    public override int GetHashCode() => Uri.GetHashCode();

    /// <value>http://www.w3.org/2001/XMLSchema#</value>
    public const string XmlSchemaNamespace = "http://www.w3.org/2001/XMLSchema#";

    /// <value>xs</value>
    public const string ShortXmlSchemaNamespace = "xs";

    /// <value>http://www.w3.org/TR/2002/WD-xquery-operators-20020816</value>
    public const string XQueryOperatorsNameSpace =
        "http://www.w3.org/TR/2002/WD-xquery-operators-20020816";

    /// <value>xquery</value>
    public const string ShortXQueryOperatorsNameSpace = "xquery";

    /// <value>urn:oasis:names:tc:xacml:1.0</value>
    public const string Xacml10Namespace = "urn:oasis:names:tc:xacml:1.0";

    /// <value>xacml</value>
    public const string ShortXacml10Namespace = "xacml";

    /// <value>urn:oasis:names:tc:xacml:2.0</value>
    public const string Xacml20Namespace = "urn:oasis:names:tc:xacml:2.0";

    /// <value>xacml</value>
    public const string ShortXacml20Namespace = "xacml";

    /// <value>urn:oasis:names:tc:xacml:3.0</value>
    public const string Xacml30Namespace = "urn:oasis:names:tc:xacml:3.0";

    /// <value>xacml</value>
    public const string ShortXacml30Namespace = "xacml";

    /// <value>http://www.w3.org/2000/09/xmldsig#</value>
    public const string XmlSignatureConstantsNamespace = "http://www.w3.org/2000/09/xmldsig#";

    /// <value>ds</value>
    public const string ShortXmlSignatureConstantsNamespace = "ds";

    /// <value>http://schemas.xmlsoap.org</value>
    public const string SoapNamespacePrefix = "http://schemas.xmlsoap.org";

    /// <value><inheritdoc cref="SoapNamespacePrefix" path="/value" />/identity/claims</value>
    public const string SoapNamespace = SoapNamespacePrefix + "/identity/claims";

    /// <value><inheritdoc cref="SoapNamespacePrefix" path="/value" />/ws/2005/05/identity/claims</value>
    public const string Soap2005Namespace = SoapNamespacePrefix + "/ws/2005/05/identity/claims";

    /// <value><inheritdoc cref="SoapNamespacePrefix" path="/value" />/ws/2005/05/identity/claims</value>
    public const string Soap2008Namespace = SoapNamespacePrefix + "/ws/2008/06/identity/claims";

    /// <value><inheritdoc cref="Soap2005Namespace" path="/value" />/phone</value>
    public const string PhoneNumberUri = Soap2005Namespace + "/phone";

    /// <value><inheritdoc cref="ShortSoapSchemaNamespace" path="/value" />:phone</value>
    public const string PhoneNumberShortUri = ShortSoapSchemaNamespace + ":phone";

    /// <value>soap</value>
    public const string ShortSoapSchemaNamespace = "soap";

    public override string? ToString() => Value?.ToString();

    public class EFCoreConverter<TClaimValueType, TPersistedType>
        : ValueConverter<TClaimValueType?, TPersistedType?>
        where TClaimValueType : notnull, IClaimValueType
        where TPersistedType : notnull
    {
        public EFCoreConverter()
            : base(
                v => (TPersistedType)v.Value,
                v => (TClaimValueType)Activator.CreateInstance(typeof(TClaimValueType), v)
            ) { }
    }

    public static ClaimValueType[] GetAll() =>
        CurrentDomain
            .GetAssemblies()
            .SelectMany(
                asm =>
                    asm.GetExportedTypes()
                        .Where(
                            t =>
                                !t.ContainsGenericParameters
                                && typeof(ClaimValueType).IsAssignableFrom(t)
                        )
            )
            .Select(
                t =>
                    t.GetField("Instance")?.GetValue(null)
                    ?? t.GetProperty("Instance")?.GetValue(null)
                    ?? null
            )
            .OfType<ClaimValueType>()
            .WhereNotNull()
            .ToArray();
}
