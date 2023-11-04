using System.IO.IsolatedStorage;

/*
 * RoleStore.cs
 *
 *   Created: 2022-12-30-11:08:42
 *   Modified: 2022-12-30-11:08:43
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity;

using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.Identity.Client;

using Dgmjr.Identity.Models;

using MSIDR = MSID.IdentityResult;

[GenerateInterface]
public interface IRoleStore<TKey, TUser, TRole> : IRoleStore<TRole>
    where TRole : class, IIdentityRole<TKey, TUser, TRole>
    where TUser : class, IIdentityUser<TKey, TUser, TRole>
    where TKey : IEquatable<TKey>, IComparable
{ }

public class RoleStore<TKey, TUser, TRole>(
    IIdentityDbContext<TUser, TRole> db,
    IdentityErrorDescriber errors
) : IRoleStore<TRole>, IHaveADbContext<IIdentityDbContext<TUser, TRole>>
    where TRole : class, IIdentityRole<TKey, TUser, TRole>
    where TUser : class, IIdentityUser<TKey, TUser, TRole>
    where TKey : IEquatable<TKey>, IComparable
{
    public IIdentityDbContext<TUser, TRole> Db { get; } = db;
public IdentityErrorDescriber Errors { get; } = errors;

protected async Task<MSIDR> ProtectedCreateAsync(
    TRole role,
    CancellationToken cancellationToken
)
{
    await Db.Roles.AddAsync(role, cancellationToken);
    await Db.SaveChangesAsync(cancellationToken);
    return IdentityResult.Success("Role created successfully.");
}

public async Task<MSIDR> UpdateAsync(TRole role, CancellationToken cancellationToken)
{
    Db.Roles.Update(role);
    await Db.SaveChangesAsync(cancellationToken);
    return IdentityResult.Success("Role updated successfully.");
}

public async Task<MSIDR> DeleteAsync(TRole role, CancellationToken cancellationToken)
{
    Db.Roles.Remove(role);
    await Db.SaveChangesAsync(cancellationToken);
    return IdentityResult.Success("Role deleted successfully.");
}

public Task<string> GetRoleIdAsync(TRole role, CancellationToken cancellationToken)
{
    return Task.FromResult(role.Id.ToString()!);
}

public Task<string?> GetRoleNameAsync(TRole role, CancellationToken cancellationToken)
{
    return Task.FromResult<string?>(role.Name);
}

async Task IRoleStore<TRole>.SetRoleNameAsync(
    TRole role,
    string? roleName,
    CancellationToken cancellationToken
)
{
    await SetRoleNameAsync(role, roleName, cancellationToken);
}

public async Task<MSIDR> SetRoleNameAsync(
    TRole role,
    string roleName,
    CancellationToken cancellationToken
)
{
    (role as IdentityRole).Name = roleName;
    await Db.SaveChangesAsync(cancellationToken);
    return IdentityResult.Success("Role name set successfully.");
}

public Task<string?> GetNormalizedRoleNameAsync(TRole role, CancellationToken cancellationToken)
{
    return Task.FromResult<string?>(role.NormalizedName);
}

async Task IRoleStore<TRole>.SetNormalizedRoleNameAsync(
    TRole role,
    string? normalizedName,
    CancellationToken cancellationToken
)
{
    (role as IdentityRole).NormalizedName = normalizedName;
    await Db.SaveChangesAsync(cancellationToken);
}

public async Task<MSIDR> SetNormalizedRoleNameAsync(
    TRole role,
    string normalizedName,
    CancellationToken cancellationToken
)
{
    (role as IdentityRole).NormalizedName = normalizedName;
    await Db.SaveChangesAsync(cancellationToken);
    return IdentityResult.Success("Normalized role name set successfully.");
}

public async Task<TRole?> FindByIdAsync(string roleId, CancellationToken cancellationToken)
{
    return await Db.Roles.FindAsync(new object[] { roleId }, cancellationToken) as TRole;
}

public async Task<TRole?> FindByNameAsync(
    string normalizedRoleName,
    CancellationToken cancellationToken
)
{
    return await Db.Roles.FirstOrDefaultAsync(
            r => r.NormalizedName == normalizedRoleName,
            cancellationToken
        ) as TRole;
}

public async Task<TRole?> FindByUriAsync(uri uri, CancellationToken cancellationToken)
{
    return await Db.Roles.FirstOrDefaultAsync(r => r.Uri == uri, cancellationToken) as TRole;
}

public async Task<MSIDR> CreateAsync(TRole role, CancellationToken cancellationToken)
{
    return await ProtectedCreateAsync(role, cancellationToken);
}

private bool disposedValue = false; // To detect redundant calls

protected virtual void Dispose(bool disposing)
{
    if (!disposedValue)
    {
        if (disposing)
        {
            // Dispose managed state (managed objects)
            Db.Dispose();
        }

        // Free unmanaged resources (unmanaged objects) and override finalizer
        // Set large fields to null
        disposedValue = true;
    }
}

// // Override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
// ~RoleStore()
// {
//     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
//     Dispose(disposing: false);
// }

// Implement IDisposable.
// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
public void Dispose()
{
    // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    Dispose(disposing: true);
    GC.SuppressFinalize(this);
}
}
