/*
 * Operations.cs
 *
 *   Created: 2022-12-16-05:17:48
 *   Modified: 2022-12-16-05:17:48
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Dgmjr.Identity.Authorization.Enums
{
    [GenerateEnumerationClass("Operations", "Dgmjr.Identity.Authorization")]
    public enum Operation
    {
        Create,
        Read,
        Update,
        Delete
        //     public static readonly OperationAuthorizationRequirement Create =
        //         new OperationAuthorizationRequirement { Name = "Create" };
        // public static readonly OperationAuthorizationRequirement Read =
        //     new OperationAuthorizationRequirement { Name = "Read" };
        // public static readonly OperationAuthorizationRequirement Update =
        //     new OperationAuthorizationRequirement { Name = "Update" };
        // public static readonly OperationAuthorizationRequirement Delete =
        //     new OperationAuthorizationRequirement { Name = "Delete" };
    }
}

namespace Dgmjr.Identity.Authorization
{
    public partial sealed class Operations : OperationAuthorizationRequirement, IEquatable<Operations>
    {
        public virtual bool Equals(Operations? op) => Name == op?.Name;
    }
}
