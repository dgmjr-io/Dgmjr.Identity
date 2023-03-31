namespace Dgmjr.Identity.Abstractions;

public interface IUserLoginThing : IIdentifiable<int>
{
    int ProviderId { get; set; }
    string ProviderName { get; set; }
    long UserId { get; set; }
}
