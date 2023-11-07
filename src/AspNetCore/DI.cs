/*
 * DI.cs
 *
 *   Created: 2022-12-13-08:37:44
 *   Modified: 2022-12-13-08:37:44
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Dgmjr.Identity;
using Dgmjr.Identity.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using IdentityDbContext = Dgmjr.Identity.IdentityDbContext;

namespace Microsoft.Extensions.DependencyInjection;

public static class IdentityDependencyInjectionExtensions
{
    public static WebApplicationBuilder AddIdentity<TKey, TUser, TRole>(
        this WebApplicationBuilder builder,
        bool addDefaultUI = false
    )
        where TUser : class, IIdentityUser<TKey, TUser, TRole>
        where TRole : class, IIdentityRole<TKey, TUser, TRole>
        where TKey : IEquatable<TKey>, IComparable
    {
        _ = builder.Services.AddSingleton<IPassphraseGenerator, PassphraseGenerator>();
        _ = builder.Services.Configure<PassphraseGeneratorOptions>(
            builder.Configuration.GetSection("PassphraseGeneratorOptions")
        );

        // _ = builder.Services.AddRazorPages();
        //_ = builder.Services.AddSingleton<ISystemClock, SystemClock>();
        var idBuilder = builder.Services
            .AddIdentityCore<TUser>(options => //.AddIdentity<User, Role>(options =>
            // _ = builder.Services.AddIdentity<User, Role>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 16;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            })
            .AddEntityFrameworkStores<IdentityDbContext>()
            .AddDefaultTokenProviders()
            .AddClaimsPrincipalFactory<DgmjrId.UserClaimsPrincipalFactory<TUser>>()
            .AddSignInManager<DgmjrId.SignInManager<TUser>>()
            .AddRoles<TRole>()
            .AddRoleStore<RoleStore<TKey, TUser, TRole>>()
            // .AddRoleManager<RoleManager>()
            .AddUserManager<UserManager<TUser, TRole>>()
            .AddErrorDescriber<DgmjrId.IdentityErrorDescriber>()
            .AddUserValidator<DgmjrId.UserValidator<TUser>>()
            .AddPasswordValidator<DgmjrId.PasswordValidator<TUser>>();
        if (addDefaultUI)
        {
            idBuilder.AddDefaultUI();
        }
        return builder;
    }
}
