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
    public new virtual TValue Value
    {
        get => (TValue)base.Value;
        set => base.Value = value;
    }

    public static implicit operator TValue(ClaimValueType<TValue> cvt) => cvt.Value;
}

public partial record class ClaimValueType : IdentityComponent, IClaimValueType
{
    // public virtual bool Equals(IIdentityComponent? other)
    //     => Equals(other as IClaimValueType);

    public virtual bool Equals(IClaimValueType? other)
    {
        return other is not null
            && (ReferenceEquals(this, other) || ((IClaimValueType)this).Uri == other.Uri);
    }

    public object Value { get; set; }

    string IIdentityComponent.Name => string.Empty;
    string IHaveAUriString.UriString => "about:blank";
    public virtual uri Uri => ((IIdentityComponent)this).UriString;
    public virtual uri ShortUri => ((IIdentityComponent)this).ShortUriString;

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

    /// <value>soap</value>
    public const string ShortSoapSchemaNamespace = "soap";

    public override string? ToString() => Value?.ToString();

    public class EFCoreConverter<TClaimValueType, TPersistedType>
        : Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter<
            TClaimValueType?,
            TPersistedType?
        >
        where TClaimValueType : notnull, IClaimValueType
        where TPersistedType : notnull
    {
        public EFCoreConverter()
            : base(
                v => (TPersistedType)v.Value,
                v => (TClaimValueType)Activator.CreateInstance(typeof(TClaimValueType), v)
            )
        { }
    }
}
