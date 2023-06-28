namespace Dgmjr.Identity.Claims;
using Dgmjr.Identity.Claims.Abstractions;
using global::System;

public abstract class ClaimType : ClaimValueOrTypeBase, IClaimTypeOrValue
{

    public override int GetHashCode() => Uri.GetHashCode();
}
