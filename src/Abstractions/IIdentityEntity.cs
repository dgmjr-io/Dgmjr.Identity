/*
 * IIdentityEntity.cs
 *
 *   Created: 2023-10-06-08:20:50
 *   Modified: 2023-10-10-09:29:16
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

public interface IIdentityEntity<TKey> : IHaveAWritableId<TKey>,
                                         IIdentifiable,
                                         IEntity<IIdentityEntity<TKey>, TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    [PersonalData, Key, DbGen(DbGen.Identity), Hashids]
    new TKey Id
    {
        get;
        set;
    }
}

public interface IIdentityEntity : IEntity { }
