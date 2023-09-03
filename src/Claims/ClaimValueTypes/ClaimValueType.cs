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
using global::System;
using global::System.Security;

public partial record class ClaimValueType<TValue> : ClaimValueType
{
    public new virtual TValue Value { get => (TValue)base.Value; set => base.Value = value; }
}

public partial record class ClaimValueType : ClaimTypeOrValueType, IClaimValueType
{
    // public virtual bool Equals(IClaimTypeOrValueType? other)
    //     => Equals(other as IClaimValueType);

    public virtual bool Equals(IClaimValueType? other)
    {
        return other is not null && (ReferenceEquals(this, other) || ((IClaimValueType)this).Uri == other.Uri);
    }

    public object Value { get; set; }

    string IClaimTypeOrValueType.Name => string.Empty;
    string IClaimTypeOrValueType.UriString => "about:blank";
    public virtual uri Uri => ((IClaimTypeOrValueType)this).UriString;
    public virtual uri ShortUri => ((IClaimTypeOrValueType)this).ShortUriString;

    // public override bool Equals(object? other) => Equals(other as IClaimValueType);

    public override int GetHashCode() => Uri.GetHashCode();

    /// <value>http://www.w3.org/2001/XMLSchema</value>
    public const string XmlSchemaNamespace = "http://www.w3.org/2001/XMLSchema";
    /// <value>xs</value>
    public const string ShortXmlSchemaNamespace = "xs";

    /// <value>http://www.w3.org/TR/2002/WD-xquery-operators-20020816</value>
    public const string XQueryOperatorsNameSpace = "http://www.w3.org/TR/2002/WD-xquery-operators-20020816";
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

    /// <value>http://schemas.xmlsoap.org/</value>
    public const string SoapSchemaNamespace = "http://schemas.xmlsoap.org/";
    /// <value>soap</value>
    public const string ShortSoapSchemaNamespace = "soap";

    public override string ToString() => Value?.ToString();
}


public class ClaimValueTypeEntityFrameworkCoreConverter<TClaimValueType, TPersistedType> : Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter<TClaimValueType, TPersistedType>
{
    public ClaimValueTypeEntityFrameworkCoreConverter() : base(v => (TPersistedType)(object)v, v => (TClaimValueType)(object)v) { }
}
