using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace Dgmjr.Identity.Models;

public class ApplicationClaimsIssuer<TKey>
    : ApplicationIdentityEntity<TKey>,
        IIdentityClaimsIssuer<TKey, ApplicationUserClaim<TKey>, ApplicationRoleClaim<TKey>>
    where TKey : IEquatable<TKey>, IComparable
{
    public uri Uri { get; set; }

    public virtual ICollection<ApplicationUserClaim<TKey>> UserClaims { get; }

    public virtual ICollection<ApplicationRoleClaim<TKey>> RoleClaims { get; }

    public virtual string Name { get; set; }
    public virtual string Description { get; set; }
}
