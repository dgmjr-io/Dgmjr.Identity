namespace Dgmjr.Identity.Abstractions;

public interface IUserLoginThing : IUserAssociatedEntity
{
    int ProviderId { get; set; }
    string ProviderName { get; set; }
}
