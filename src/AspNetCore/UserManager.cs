/*
 * UserManager.cs
 *
 *   Created: 2022-12-13-10:53:25
 *   Modified: 2022-12-13-10:53:25
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Security.Claims;
using Dgmjr.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MSIDR = Microsoft.AspNetCore.Identity.IdentityResult;

namespace Dgmjr.Identity;

public class UserManager<TUser, TRole>(
    IUserStore<TUser> store,
    IOptions<IdentityOptions> optionsAccessor,
    IPasswordHasher<TUser> passwordHasher,
    IEnumerable<IUserValidator<TUser>> userValidators,
    IEnumerable<IPasswordValidator<TUser>> passwordValidators,
    ILookupNormalizer keyNormalizer,
    IdentityErrorDescriber errors,
    IServiceProvider services,
    ILogger<UserManager<TUser>> logger,
    IIdentityDbContext<TUser, TRole> db,
    IPasswordGenerator passwordGenerator
)
    : UserManager<TUser>(
        store,
        optionsAccessor,
        passwordHasher,
        userValidators,
        passwordValidators,
        keyNormalizer,
        errors,
        services,
        logger
    ),
        IHaveADbContext<IIdentityDbContext<TUser, TRole>>
    where TUser : class, IIdentityUserBase
    where TRole : class, IIdentityRoleBase
{
    private readonly IPasswordGenerator _passwordGenerator = passwordGenerator;
    public IIdentityDbContext<TUser, TRole> Db { get; } = db;

    // IDbContext IHaveADbContext.Db => Db;
    public override IQueryable<TUser> Users => Db.Users;

    public virtual Task<TUser?> FindByIdAsync(int userId) => FindByIdAsync(userId.ToString());

    public override Task<TUser?> FindByNameAsync(string userName)
    {
        if (userName is null)
            throw new ArgumentNullException(nameof(userName));

        var users = Users ?? Db.Users;
        return users.FirstOrDefaultAsync(u => u.Username == userName);
    }

    // public override async Task<IList<C>> GetClaimsAsync(TUser user)
    // {
    //     if (user is null)
    //         throw new ArgumentNullException(nameof(user));

    //     var claims = await Db.UserClaims
    //         .Where(uc => uc.UserId == user.Id)
    //         .Select(uc => uc.ToClaim())
    //         .ToListAsync();
    //     return claims;
    // }

    // public override async Task<MSIDR> AddClaimAsync(TUser user, Claim claim)
    // {
    //     return user is null
    //         ? throw new ArgumentNullException(nameof(user))
    //         : claim is null
    //             ? throw new ArgumentNullException(nameof(claim))
    //             : user.Claims.Any(c => c.ClaimType == claim.Type && c.ClaimValue == claim.Value)
    //                 ? MSIDR.Success
    //                 : await AddUserClaimAsync(user, UserClaim.FromClaim(user.Id, claim));

    //     async Task<MSIDR> AddUserClaimAsync(TUser user, UserClaim claim)
    //     {
    //         user.Claims.Add(claim);
    //         _ = Db.Users.Update(user);
    //         return await Db.SaveChangesAsync(default).ContinueWith(t => MSIDR.Success);
    //     }
    //     ;
    // }

    public virtual async Task<string> GeneratePasswordAsync(TUser user)
    {
        var password = _passwordGenerator.GeneratePassword();
        return (await AddPasswordAsync(user, password)).Succeeded
            ? password
            : throw new Exception("Failed to generate password");
    }
}
