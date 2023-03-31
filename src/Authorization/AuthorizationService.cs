/*
 * IAuthorizationService.cs
 *
 *   Created: 2022-12-16-05:39:52
 *   Modified: 2022-12-16-05:39:53
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
namespace Dgmjr.Identity.Authorization;

using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

public class AuthorizationService : Microsoft.AspNetCore.Authorization.DefaultAuthorizationService
{
    public AuthorizationService(IAuthorizationPolicyProvider policyProvider, IAuthorizationHandlerProvider handlers, ILogger<DefaultAuthorizationService> logger, IAuthorizationHandlerContextFactory contextFactory, IAuthorizationEvaluator evaluator, IOptions<AuthorizationOptions> options)
        : base(policyProvider, handlers, logger, contextFactory, evaluator, options)
    {
    }

    public override Task<AuthorizationResult> AuthorizeAsync(ClaimsPrincipal user, object? resource, IEnumerable<IAuthorizationRequirement> requirements) => base.AuthorizeAsync(user, resource, requirements);

    public override Task<AuthorizationResult> AuthorizeAsync(ClaimsPrincipal user, object? resource, string policyName) => base.AuthorizeAsync(user, resource, policyName);
}

public class AuthorizationHandler : IAuthorizationHandler
{
    public Task HandleAsync(AuthorizationHandlerContext context) => throw new NotImplementedException();
}
