using System.Threading;
using System.Threading.Tasks;

namespace Dgmjr.Graph.Identity;
using global::Microsoft.AspNetCore.Identity;
using global::Microsoft.Extensions.Options;
using global::Microsoft.Graph;
using global::Microsoft.Identity.Web;
using IdentityResult = global::Microsoft.AspNetCore.Identity.IdentityResult;

public class GraphRoleStore(GraphServiceClient graphServiceClient,
    IOptions<MicrosoftIdentityOptions> options) : GraphService(graphServiceClient, options), IRoleStore<AppRole>
{
    private readonly GraphServiceClient _graphServiceClient = graphServiceClient;
public async Task<IdentityResult> CreateAsync(AppRole role, CancellationToken cancellationToken)
{
    var app = await _graphServiceClient.Applications[
        role.AdditionalData["ApplicationId"]?.ToString()
    ]
        .Request()
        .GetAsync();
    app.AppRoles = app.AppRoles.Append(role).ToArray();
    await _graphServiceClient.Applications[app.Id].Request().UpdateAsync(app, cancellationToken);
    return IdentityResult.Success;
}

public async Task<IdentityResult> DeleteAsync(AppRole role, CancellationToken cancellationToken)
{
    var app = await _graphServiceClient.Applications[
        role.AdditionalData["ApplicationId"]?.ToString()
    ]
        .Request()
        .GetAsync();
    app.AppRoles = app.AppRoles.Except([role]).ToArray();
    await _graphServiceClient.Applications[app.Id].Request().UpdateAsync(app, cancellationToken);
    return IdentityResult.Success;
}

public async Task<AppRole?> FindByIdAsync(string roleId, CancellationToken cancellationToken)
{
    var apps = await _graphServiceClient.Applications.Request().GetAsync(cancellationToken);
    var appRole = apps.SelectMany(app => app.AppRoles).FirstOrDefault(role => role.Id == new guid(roleId));
    return appRole;
}

public async Task<AppRole?> FindByNameAsync(
    string normalizedRoleName,
    CancellationToken cancellationToken
)
{
    var app = await GetApplication();
    var appRole = app.AppRoles.FirstOrDefault(role => role.DisplayName == normalizedRoleName);
    return appRole;
}

public async Task<string?> GetNormalizedRoleNameAsync(
    AppRole role,
    CancellationToken cancellationToken
)
{
    return await Task.FromResult(role.DisplayName);
}

public async Task<string> GetRoleIdAsync(AppRole role, CancellationToken cancellationToken)
{
    return await Task.FromResult(role.Id.ToString());
}

public async Task<string?> GetRoleNameAsync(AppRole role, CancellationToken cancellationToken)
{
    return await Task.FromResult(role.DisplayName);
}

public async Task SetNormalizedRoleNameAsync(
    AppRole role,
    string? normalizedName,
    CancellationToken cancellationToken
)
{
    role.DisplayName = normalizedName;
    await UpdateAsync(role, cancellationToken);
}

public async Task SetRoleNameAsync(
    AppRole role,
    string? roleName,
    CancellationToken cancellationToken
)
{
    role.DisplayName = roleName;
    await UpdateAsync(role, cancellationToken);
}

public async Task<IdentityResult> UpdateAsync(AppRole role, CancellationToken cancellationToken)
{
    var app = await GetApplication();
    app.AppRoles = app.AppRoles.Except([role]).Append(role).ToArray();
    await _graphServiceClient.Applications[app.Id].Request().UpdateAsync(app);
    return IdentityResult.Success;
}
}
