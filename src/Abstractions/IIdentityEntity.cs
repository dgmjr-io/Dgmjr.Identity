namespace Dgmjr.Identity.Abstractions;

public interface IIdentityEntity<TKey> : IHaveAWritableId<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    [PersonalData, Key, DbGen(DbGen.None), Column(nameof(Id))]
    new TKey Id { get; set; }
}
