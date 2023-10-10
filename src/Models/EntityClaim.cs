using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;

namespace Dgmjr.Identity.Models;

public abstract class EntityClaim<TSelf, TKey> : IEntityClaim<TSelf, TKey>
    where TKey : IEquatable<TKey>, IComparable
    where TSelf : IEntityClaim<TSelf, TKey>, new()
{
    [Required, NotMapped]
    public TKey EntityId
    {
        get
        {
            try
            {
                return (TKey)Convert.ChangeType(Properties[nameof(EntityId)], typeof(TKey));
            }
            catch
            {
                return default!;
            }
        }
        set => Properties[nameof(EntityId)] = value.ToString();
    }

    [Required, Url, StringLength(UriMaxLength, MinimumLength = 0), Column()]
    public string? Value
    {
        get => Properties[nameof(Value)];
        set => Properties[nameof(Value)] = value;
    }

    [
        Required,
        Url,
        StringLength(UriMaxLength, MinimumLength = 0),
        DefaultValue(DgmjrCt.Unknown.UriString)
    ]
    public uri? Type
    {
        get => uri.From(Properties[nameof(Type)]);
        set => Properties[nameof(Type)] = value;
    }

    [
        Required,
        Url,
        StringLength(UriMaxLength, MinimumLength = 0),
        DefaultValue(DgmjrCvt.String.UriString)
    ]
    public uri? ValueType
    {
        get => uri.From(Properties[nameof(ValueType)]);
        set => Properties[nameof(ValueType)] = value;
    }

    [Required, Url, StringLength(UriMaxLength, MinimumLength = 0), DefaultValue(DgmjrIo)]
    public uri? Issuer
    {
        get => uri.From(Properties[nameof(Issuer)]);
        set => Properties[nameof(Issuer)] = value;
    }

    [Required, Url, StringLength(UriMaxLength, MinimumLength = 0), DefaultValue(DgmjrIo)]
    public uri? OriginalIssuer
    {
        get => uri.From(Properties[nameof(OriginalIssuer)]);
        set => Properties[nameof(OriginalIssuer)] = value;
    }
    public IStringDictionary Properties { get; set; } = new StringDictionary();

    public TKey Id { get; set; }

    public void InitializeFromClaim(C? claim)
    {
        Properties = claim.Properties;
        Type = claim.Type ?? Dgmjr.Identity.ClaimTypes.UnknownClaimType.Instance.Uri;
        Value = claim.Value;
        Issuer = claim.Issuer ?? DgmjrIdentity;
        OriginalIssuer = claim.OriginalIssuer ?? DgmjrIdentity;
        ValueType = claim.ValueType ?? ClaimValueTypes.String.Instance.Uri;
        EntityId = claim.Properties.ContainsKey(nameof(EntityId))
            ? (TKey)Convert.ChangeType(claim.Properties[nameof(EntityId)], typeof(TKey))
            : default;
        Id = claim.Properties.ContainsKey(nameof(Id))
            ? (TKey)Convert.ChangeType(claim.Properties[nameof(Id)], typeof(TKey))
            : default;
    }

    public C ToClaim()
    {
        return new C(Type, Value, ValueType, Issuer, OriginalIssuer);
    }

    public static TSelf FromClaim(C claim)
    {
        var newClaim = new TSelf();
        newClaim.InitializeFromClaim(claim);
        return newClaim;
    }
}
