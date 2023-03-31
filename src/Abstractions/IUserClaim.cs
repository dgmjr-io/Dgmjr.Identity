/*
 * IUserClaim.cs
 *
 *   Created: 2022-12-23-06:21:08
 *   Modified: 2022-12-23-06:21:09
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

public interface IUserClaim : IEntityClaim<IUserClaim>, IUserAssociatedEntity
{
#if NET6_0_OR_GREATER
    public int UserId { get => EntityId; set => EntityId = value; }
#else
#endif
}
