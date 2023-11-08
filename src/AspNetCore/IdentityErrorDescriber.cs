namespace Dgmjr.Identity;

public class IdentityErrorDescriber : MSID.IdentityErrorDescriber {
  public override MSID.IdentityError UserNotInRole(string role) {
    return new MSID.IdentityError { Code = nameof(UserNotInRole),
                                    Description =
                                        $"User is not in role {role}." };
  }
}
