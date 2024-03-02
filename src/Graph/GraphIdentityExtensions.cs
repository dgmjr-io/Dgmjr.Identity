namespace Microsoft.Extensions.DependencyInjection;

using global::Microsoft.AspNetCore.Identity;
using Dgmjr.Identity;
using global::Microsoft.AspNetCore.Builder;

public static class GraphIdentityExtensions
{
    public static WebApplicationBuilder AddGraphIdentity(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IUserStore<Microsoft.Graph.User>, GraphUserStore>();
        builder.Services.AddScoped<IUserEmailStore<Microsoft.Graph.User>, GraphUserStore>();
        builder.Services.AddScoped<IUserRoleStore<Microsoft.Graph.User>, GraphUserStore>();
        builder.Services.AddScoped<IRoleStore<Microsoft.Graph.AppRole>, GraphRoleStore>();
        builder.Services.AddScoped<UserManager<Microsoft.Graph.User>>();
        builder.Services.AddScoped<Microsoft.AspNetCore.Identity.RoleManager<Microsoft.Graph.AppRole>>();
        builder.Services.AddSingleton<
            IPasswordHasher<Microsoft.Graph.User>,
            PasswordHasher<Microsoft.Graph.User>
        >();
        builder.Services.AddSingleton<ILookupNormalizer, UpperInvariantLookupNormalizer>();
        builder.Services.AddSingleton<Microsoft.AspNetCore.Identity.IdentityErrorDescriber>();

        builder.Services.AddSingleton<IPassphraseGenerator, PassphraseGenerator>();
        builder.Services.Configure<PassphraseGeneratorOptions>(
            builder.Configuration.GetSection(nameof(PassphraseGeneratorOptions))
        );
        builder.Services.AddScoped<Microsoft.AspNetCore.Identity.SignInManager<Microsoft.Graph.User>>();
        builder.Services.AddScoped<
            IUserClaimsPrincipalFactory<Microsoft.Graph.User>,
            Microsoft.AspNetCore.Identity.UserClaimsPrincipalFactory<Microsoft.Graph.User>
        >();
        builder.Services.AddScoped<
            IUserConfirmation<Microsoft.Graph.User>,
            DefaultUserConfirmation<Microsoft.Graph.User>
        >();
        return builder;
    }
}
