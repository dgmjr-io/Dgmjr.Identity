using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Dgmjr.Identity.Models;

public abstract class EntityClaim<TKey> : IEntityClaim<EntityClaim<TKey>, TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    public TKey EntityId { get; set; }
    public string? Value { get; set; }
    public uri? Type { get; set; }
    public uri? ValueType { get; set; }
    public uri? Issuer { get; set; }
    public uri? OriginalIssuer { get; set; }
    public IStringDictionary Properties { get; set; }

    public TKey Id { get; set; }

    public void InitializeFromClaim(C? claim)
    {
        Type = Value = claim.Value;
        Issuer = claim.Issuer.CreateUri(DgmjrCt.GenericClaimsIssuerTypePattern)!;
        OriginalIssuer = claim.OriginalIssuer.CreateUri(DgmjrCt.GenericClaimsIssuerTypePattern)!;
        Properties = claim.Properties;
        ValueType = ClaimValueTypes.String.Instance.Uri;
        EntityId = claim.Properties.ContainsKey(nameof(EntityId))
            ? int.Parse(claim.Properties[nameof(RoleId)])
            : default;
        Id = claim.Properties.ContainsKey(nameof(Id))
            ? int.Parse(claim.Properties[nameof(Id)])
            : default;
    }

    public C ToClaim()
    {
        throw new NotImplementedException();
    }
}
