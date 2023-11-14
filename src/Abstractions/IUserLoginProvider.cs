namespace Dgmjr.Identity.Models.Abstractions;

public partial interface IUserLoginProvider
    : IHaveADescription,
        IHaveADisplayName,
        IHaveAName,
        IHaveAuri
{ }
