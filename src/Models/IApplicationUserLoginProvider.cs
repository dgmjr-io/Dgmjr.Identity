namespace Dgmjr.Identity.Models.Abstractions;

public partial interface IApplicationUserLoginProvider : IHaveADescription,
                                                         IHaveADisplayName,
                                                         IHaveAName,
                                                         IHaveAuri
{ }
