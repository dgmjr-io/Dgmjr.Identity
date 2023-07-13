namespace Dgmjr.Identity.Claims;
using Dgmjr.Identity;

/// <summary>
/// The SoaplaimBaseType class is an abstract class that extends the ClaimType class and implements the IClaimTypeOrValue interface. It provides properties and fields for working with SOAP claims.
/// </summary>
public abstract class SoapClaimBaseType : ClaimType, IClaimTypeOrValue
{
    /// <summary>
    /// A constant string representing the default short URI separator.
    /// </summary>
    /// <value>:</value>
    public new const string _ShortUriSeparator = Constants.DefaultShortUriSeparator;

    /// <summary>
    /// A constant string representing the default long URI separator.
    /// </summary>
    /// <value>/</value>
    public new const string _LongUriSeparator = Constants.DefaultLongUriSeparator;

    /// <summary>
    /// A constant string representing the SOAP short URI prefix.
    /// </summary>
    ///<value>ws</value> 
    public new const string _ShortUriPrefix = Constants.soap;

    ///<summary>A constant string representing the SOAP long URI prefix.</summary> 
    ///<value>http://schmemas.xmlsoap.org</value> 
    public new const string _LongUriPrefix = Constants.Soap;

    ///<summary>
    ///A constant string representing the default claim name.
    ///</summary>
    ///<value>claims</value> 
    public new const string _Name = Constants.DefaultClaimName;

    ///<summary>
    ///A constant string representing the full SOAP long URI, which includes the long URI prefix, long URI separator, and claim name.
    ///</summary>
    ///<value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="_LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value> 
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";

    ///<summary>
    ///A constant string representing the full SOAP short URI, which includes the short URI prefix, short URI separator, and claim name.
    ///</summary>
    ///<value>ws:claim</value> 
    public new const string _ShortUriString = $"{ClaimType.ShortUriPrefix}{ClaimType.ShortUriSeparator}{Name}";

    ///<inheritdoc cref="Name"/>
    public override string Name => _Name;

    ///<inheritdoc cref="LongUriPrefix"/>
    public override string LongUriPrefix => _LongUriPrefix;

    ///<inheritdoc cref="ShortUriPrefix"/>
    public override string ShortUriPrefix => _ShortUriPrefix;

    ///<inheritdoc cref="LongUriSeparator"/>
    public override string LongUriSeparator => _LongUriSeparator;

    ///<inheritdoc cref="ShortUriSeparator"/>
    public override string ShortUriSeparator => _ShortUriSeparator;

    ///<inheritdoc cref="LongUriString"/>
    public override string LongUriString => _LongUriString;

    ///<inheritdoc cref="ShortUriString" />
    public override string ShortUriString => _ShortUriString;
}
