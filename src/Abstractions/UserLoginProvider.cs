namespace Dgmjr.Identity.Models;

public partial record struct UserLoginProvider
{
    public static Dgmjr.Identity.Models.Abstractions.IUserLoginProvider FromId(int id) =>
        UserLoginProvider.FromValue((Dgmjr.Identity.Models.Enums.UserLoginProvider)id);
}
