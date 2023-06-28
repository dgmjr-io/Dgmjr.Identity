namespace Dgmjr.Identity;

public static class Constants
{
    /// <value>https://dgmjr.io</value>
    public const string Dgmjr_IO = "https://dgmjr.io";
    /// <value>dgmjr</value>
    public const string Dgmjr = "dgmjr";

    /// <value><inheritdoc cref="Dgmjr_IO" path="/value" /></value>
    public const string DefaultLongUriPrefix = Dgmjr_IO;
    /// <value><inheritdoc cref="Dgmjr" path="/value" /></value>
    public const string DefaultShortUriPrefix = Dgmjr;
    public const string DefaultClaimName = "claim";

    /// <value>identity</value>
    public const string identity = nameof(identity);
    /// <value>value</value>
    public const string value = nameof(value);
    /// <value>claim</value>
    public const string claim = nameof(claim);
    /// <value>/</value>
    public const string DefaultLongUriSeparator = "/";
    /// <value>:</value>
    public const string DefaultShortUriSeparator = ":";

    /// <value>soap</value>
    public const string soap = nameof(soap);

    /// <value>users</value>
    public const string users = nameof(users);
    /// <value>users</value>
    public const string identity_provider = nameof(identity_provider);

    /// <value>http://schemas.xmlsoap.org/ws/2005/05</value>
    public const string Soap2005 = "http://schemas.xmlsoap.org/ws/2005/05";

    /// <value>http://schemas.xmlsoap.org/ws/2009/09</value>
    public const string Soap2009 = "http://schemas.xmlsoap.org/ws/2009/09";

    /// <value>http://schemas.microsoft.com/ws/2008/06</value>
    public const string Microsoft2008 = "http://schemas.microsoft.com/ws/2008/06";

    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims</value>
    public const string Soap2005Identity = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims";

    /// <value>http://schemas.xmlsoap.org/ws/2009/09/identity/claims</value>
    public const string Soap2009Identity = "http://schemas.xmlsoap.org/ws/2009/09/identity/claims";

    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims</value>
    public const string Microsoft2008Identity = "http://schemas.microsoft.com/ws/2008/06/identity/claims";
}
