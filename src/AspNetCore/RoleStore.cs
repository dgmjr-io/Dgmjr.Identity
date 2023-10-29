// /*
//  * RoleStore.cs
//  *
//  *   Created: 2022-12-30-11:08:42
//  *   Modified: 2022-12-30-11:08:43
//  *
//  *   Author: David G. Moore, Jr. <david@dgmjr.io>
//  *
//  *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
//  *      License: MIT (https://opensource.org/licenses/MIT)
//  */

// namespace Dgmjr.Identity;

// using Microsoft.EntityFrameworkCore.Abstractions;
// using Dgmjr.Identity.Models;
// using Microsoft.AspNetCore.Identity;
// using System.Threading;
// using System.Threading.Tasks;
// using Microsoft.Identity.Client;
// using MSIDR = AspNetId.IdentityResult;

// public class RoleStore<TUser, TRole>
//     : IRoleStore<TRole>,
//         IHaveADbContext<IIdentityDbContext<TUser, TRole>>
//     where TRole : class, IIdentityRoleBase
//     where TUser : class, IIdentityUserBase
// {
//     public IIdentityDbContext<TUser, TRole> Db { get; }
//     public IdentityErrorDescriber Errors { get; }

//     public RoleStore(IIdentityDbContext db, IdentityErrorDescriber errors)
//     {
//         Db = db;
//         Errors = errors;
//     }

//     protected async Task<IdentityResult> ProtectedCreateAsync(
//         TRole role,
//         CancellationToken cancellationToken
//     )
//     {
//         await Db.Roles.AddAsync(role, cancellationToken);
//         await Db.SaveChangesAsync(cancellationToken);
//         return IdentityResult.Success("Role created successfully.");
//     }

//     public async Task<IdentityResult> UpdateAsync(TRole role, CancellationToken cancellationToken)
//     {
//         Db.Roles.Update(role as IdentityRole);
//         await Db.SaveChangesAsync(cancellationToken);
//         return IdentityResult.Success("Role updated successfully.");
//     }

//     public async Task<IdentityResult> DeleteAsync(TRole role, CancellationToken cancellationToken)
//     {
//         Db.Roles.Remove(role as IdentityRole);
//         await Db.SaveChangesAsync(cancellationToken);
//         return IdentityResult.Success("Role deleted successfully.");
//     }

//     public async Task<string> GetRoleIdAsync(TRole role, CancellationToken cancellationToken)
//     {
//         return await Task.FromResult((role as IdentityRole).Id);
//     }

//     public Task<string> GetRoleNameAsync(TRole role, CancellationToken cancellationToken)
//     {
//         return Task.FromResult(role.Name);
//     }

//     public async Task<IdentityResult> SetRoleNameAsync(
//         TRole role,
//         string roleName,
//         CancellationToken cancellationToken
//     )
//     {
//         (role as IdentityRole).Name = roleName;
//         await Db.SaveChangesAsync(cancellationToken);
//         return IdentityResult.Success("Role name set successfully.");
//     }

//     public Task<string> GetNormalizedRoleNameAsync(TRole role, CancellationToken cancellationToken)
//     {
//         return Task.FromResult(role.NormalizedName);
//     }

//     public async Task<IdentityResult> SetNormalizedRoleNameAsync(
//         TRole role,
//         string normalizedName,
//         CancellationToken cancellationToken
//     )
//     {
//         (role as IdentityRole).NormalizedName = normalizedName;
//         await Db.SaveChangesAsync(cancellationToken);
//         return IdentityResult.Success("Normalized role name set successfully.");
//     }

//     public async Task<TRole> FindByIdAsync(string roleId, CancellationToken cancellationToken)
//     {
//         return await Db.Roles.FindAsync(new object[] { roleId }, cancellationToken) as TRole;
//     }

//     public async Task<TRole> FindByNameAsync(
//         string normalizedRoleName,
//         CancellationToken cancellationToken
//     )
//     {
//         return await Db.Roles.FirstOrDefaultAsync(
//                 r => r.NormalizedName == normalizedRoleName,
//                 cancellationToken
//             ) as TRole;
//     }

//     public async Task<MSIDR> CreateAsync(TRole role, CancellationToken cancellationToken)
//     {
//         return await ProtectedCreateAsync(role, cancellationToken);
//     }

//     // public async Task<IdentityResult> UpdateAsync(TRole role, CancellationToken cancellationToken)
//     // {
//     //     Db.Roles.Update(role as IdentityRole);
//     //     await Db.SaveChangesAsync(cancellationToken);
//     //     return IdentityResult.Success("Role updated successfully.");
//     // }

//     // public async Task<IdentityResult> DeleteAsync(TRole role, CancellationToken cancellationToken)
//     // {
//     //     Db.Roles.Remove(role as IdentityRole);
//     //     await Db.SaveChangesAsync(cancellationToken);
//     //     return IdentityResult.Success("Role deleted successfully.");
//     // }

//     // public async Task<string> GetRoleIdAsync(TRole role, CancellationToken cancellationToken)
//     // {
//     //     return await Task.FromResult((role as IdentityRole).Id);
//     // }

//     // public Task<string> GetRoleNameAsync(TRole role, CancellationToken cancellationToken)
//     // {
//     //     return Task.FromResult(role.Name);
//     // }

//     // public async Task<IdentityResult> SetRoleNameAsync(
//     //     TRole role,
//     //     string roleName,
//     //     CancellationToken cancellationToken
//     // )
//     // {
//     //     (role as IdentityRole).Name = roleName;
//     //     await Db.SaveChangesAsync(cancellationToken);
//     //     return IdentityResult.Success("Role name set successfully.");
//     // }

//     // public Task<string> GetNormalizedRoleNameAsync(TRole role, CancellationToken cancellationToken)
//     // {
//     //     return Task.FromResult(role.NormalizedName);
//     // }

//     // public async Task<IdentityResult> SetNormalizedRoleNameAsync(
//     //     TRole role,
//     //     string normalizedName,
//     //     CancellationToken cancellationToken
//     // )
//     // {
//     //     (role as IdentityRole).NormalizedName = normalizedName;
//     //     await Db.SaveChangesAsync(cancellationToken);
//     //     return IdentityResult.Success("Normalized role name set successfully.");
//     // }

//     // public async Task<TRole> FindByIdAsync(string roleId, CancellationToken cancellationToken)
//     // {
//     //     return await Db.Roles.FindAsync(new object[] { roleId }, cancellationToken) as TRole;
//     // }

//     // public async Task<TRole> FindByNameAsync(
//     //     string normalizedRoleName,
//     //     CancellationToken cancellationToken
//     // )
//     // {
//     //     return await Db.Roles.FirstOrDefaultAsync(
//     //             r => r.NormalizedName == normalizedRoleName,
//     //             cancellationToken
//     //         ) as TRole;
//     // }

//     public void Dispose()
//     {
//         // Dispose any resources here if needed
//     }
// }
