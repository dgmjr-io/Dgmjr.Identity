namespace Dgmjr.Graph.Identity;

using global::System.Collections.Generic;
using global::System.Threading;
using global::System.Threading.Tasks;

using global::Microsoft.AspNetCore.Identity;
using global::Microsoft.Extensions.Options;
using global::Microsoft.Graph;
using global::Microsoft.Identity.Web;

public class GraphUserStore(
    GraphServiceClient graphServiceClient,
    IOptions<MicrosoftIdentityOptions> options,
    IRoleStore<global::Microsoft.Graph.AppRole> roleStore
) : GraphService(graphServiceClient, options), IUserEmailStore<User>, IUserRoleStore<User>
{
    private readonly IRoleStore<global::Microsoft.Graph.AppRole> _roleStore = roleStore;
    private readonly GraphServiceClient _graphServiceClient = graphServiceClient;
    private bool _disposedValue;

    public async Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
    {
        await _graphServiceClient.Users.Request().AddAsync(user);
        return IdentityResult.Success;
    }

    public async Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken)
    {
        await _graphServiceClient.Users[user.Id].Request().DeleteAsync();
        return IdentityResult.Success;
    }

    public async Task<User?> FindByIdAsync(string userId, CancellationToken cancellationToken)
    {
        return await _graphServiceClient.Users[userId].Request().GetAsync();
    }

    public async Task<User?> FindByNameAsync(
        string normalizedUserName,
        CancellationToken cancellationToken
    )
    {
        return (
            await _graphServiceClient.Users
                .Request()
                .Filter($"identities/any(c:c/issuerAssignedId eq '{normalizedUserName}')")
                .GetAsync()
        ).FirstOrDefault();
    }

    public async Task<string?> GetNormalizedUserNameAsync(
        User user,
        CancellationToken cancellationToken
    )
    {
        return await Task.FromResult(user.UserPrincipalName.Normalize());
    }

    public Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.Id);
    }

    public async Task<string?> GetUserNameAsync(User user, CancellationToken cancellationToken)
    {
        return await Task.FromResult(user.UserPrincipalName);
    }

    public async Task SetNormalizedUserNameAsync(
        User user,
        string? normalizedName,
        CancellationToken cancellationToken
    )
    {
        user.UserPrincipalName = normalizedName;
        await UpdateAsync(user, cancellationToken);
    }

    public async Task SetUserNameAsync(
        User user,
        string? userName,
        CancellationToken cancellationToken
    )
    {
        user.UserPrincipalName = userName;
        await UpdateAsync(user, cancellationToken);
    }

    public async Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken)
    {
        await _graphServiceClient.Users[user.Id].Request().UpdateAsync(user);
        return IdentityResult.Success;
    }

    public async Task SetEmailAsync(User user, string? email, CancellationToken cancellationToken)
    {
        user.Mail = email;
        await UpdateAsync(user, cancellationToken);
    }

    public async Task<string?> GetEmailAsync(User user, CancellationToken cancellationToken)
    {
        return await Task.FromResult(user.Mail);
    }

    public async Task<bool> GetEmailConfirmedAsync(User user, CancellationToken cancellationToken)
    {
        return await Task.FromResult(
            user.AdditionalData.TryGetValue("EmailConfirmed", out var value)
                && string.Equals(true.ToString(), value?.ToString(), OrdinalIgnoreCase)
        );
    }

    public async Task SetEmailConfirmedAsync(
        User user,
        bool confirmed,
        CancellationToken cancellationToken
    )
    {
        user.AdditionalData["EmailConfirmed"] = confirmed;
        await UpdateAsync(user, cancellationToken);
    }

    public async Task<User?> FindByEmailAsync(
        string normalizedEmail,
        CancellationToken cancellationToken
    )
    {
        return (
            await _graphServiceClient.Users
                .Request()
                .Filter($"mail eq '{normalizedEmail}'")
                .GetAsync()
        ).FirstOrDefault();
    }

    public async Task<string?> GetNormalizedEmailAsync(
        User user,
        CancellationToken cancellationToken
    ) => await Task.FromResult(user.Mail.Normalize());

    public async Task SetNormalizedEmailAsync(
        User user,
        string? normalizedEmail,
        CancellationToken cancellationToken
    )
    {
        user.Mail = normalizedEmail;
        await UpdateAsync(user, cancellationToken);
    }

    public async Task AddToRoleAsync(
        User user,
        string roleName,
        CancellationToken cancellationToken
    )
    {
        var app = await GetApplication();
        var appRole = app.AppRoles.FirstOrDefault(r => r.DisplayName == roleName);

        var role = app.AppRoles.FirstOrDefault(r => r.DisplayName == roleName);
        if (role is null)
        {
            throw new InvalidOperationException($"Role '{roleName}' not found");
        }

        user.AppRoleAssignments.Add(
            new AppRoleAssignment
            {
                AppRoleId = role.Id,
                PrincipalId = guid.Parse(user.Id),
                ResourceId = guid.Parse(app.Id)
            }
        );
        await UpdateAsync(user, cancellationToken);
    }

    public async Task RemoveFromRoleAsync(
        User user,
        string roleName,
        CancellationToken cancellationToken
    )
    {
        var appRole = await _roleStore.FindByNameAsync(roleName, cancellationToken);
        user.AppRoleAssignments.Remove(
            user.AppRoleAssignments.FirstOrDefault(r => r.AppRoleId == appRole.Id)
        );
        await UpdateAsync(user, cancellationToken);
    }

    public Task<IList<string>> GetRolesAsync(User user, CancellationToken cancellationToken)
    {
        var appRoleNames = user.AppRoleAssignments
            .Select(
                r =>
                    _roleStore
                        .FindByIdAsync(r.AppRoleId.ToString(), cancellationToken)
                        .Result.DisplayName
            )
            .ToList();
        return Task.FromResult<IList<string>>(appRoleNames);
    }

    public Task<bool> IsInRoleAsync(
        User user,
        string roleName,
        CancellationToken cancellationToken
    ) =>
        Task.FromResult(
            user.AppRoleAssignments.Any(
                r =>
                    _roleStore
                        .FindByIdAsync(r.AppRoleId.ToString(), cancellationToken)
                        .Result.DisplayName == roleName
            )
        );

    public Task<IList<User>> GetUsersInRoleAsync(
        string roleName,
        CancellationToken cancellationToken
    )
    {
        throw new NotImplementedException();
    }
}
