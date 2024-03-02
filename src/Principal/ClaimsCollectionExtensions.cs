namespace System.Security.Claims;

public static class ClaimsCollectionExtensions
{
    public static TCollection Add<TCollection>(
        this TCollection claims,
        string type,
        string value
    )
        where TCollection : ICollection<Claim>
    {
        claims.Add(new Claim(type, value));
        return claims;
    }

    public static TCollection Add<TCollection>(
        this TCollection claims,
        string type,
        string value,
        string valueType
    )
        where TCollection : ICollection<Claim>
    {
        claims.Add(new Claim(type, value, valueType));
        return claims;
    }

    public static TCollection Add<TCollection>(
        this TCollection claims,
        string type,
        string value,
        string valueType,
        string issuer
    )
        where TCollection : ICollection<Claim>
    {
        claims.Add(new Claim(type, value, valueType, issuer));
        return claims;
    }

    public static TCollection Add<TCollection>(
        this TCollection claims,
        string type,
        string value,
        string valueType,
        string issuer,
        string originalIssuer
    )
        where TCollection : ICollection<Claim>
    {
        claims.Add(new Claim(type, value, valueType, issuer, originalIssuer));
        return claims;
    }

    public static TCollection Add<TCollection>(
        this TCollection claims,
        string type,
        string value,
        string valueType,
        string issuer,
        string originalIssuer,
        ClaimsIdentity subject
    )
        where TCollection : ICollection<Claim>
    {
        claims.Add(new Claim(type, value, valueType, issuer, originalIssuer, subject));
        return claims;
    }
}
