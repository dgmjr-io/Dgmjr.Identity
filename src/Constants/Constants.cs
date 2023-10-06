namespace Dgmjr.Identity;

public static partial class Constants
{
    static Constants() { }

    public static class Schemas
    {
        public const string Identity = "id";
    }

    public static class Triggers
    {
        public const string TrUserInsteadOfUpdate = "tr_DetailedUser_Update";
        public const string TrUserInsteadOfDelete = "tr_DetailedUser_Delete";
    }

    public static class Tables
    {
        public const string tbl_ = nameof(tbl_);
        public const string UserClaim = tbl_ + nameof(UserClaim);
        public const string Role = tbl_ + nameof(Role);
        public const string RoleClaim = tbl_ + nameof(RoleClaim);
        public const string User = tbl_ + nameof(User);
        public const string UserLogin = tbl_ + nameof(UserLogin);
        public const string UserRole = tbl_ + nameof(UserRole);
        public const string UserToken = tbl_ + nameof(UserToken);

        public const string UserClaimHistory = tbl_ + nameof(UserClaimHistory);
        public const string RoleHistory = tbl_ + nameof(RoleHistory);
        public const string RoleClaimHistory = tbl_ + nameof(RoleClaimHistory);
        public const string UserHistory = tbl_ + nameof(UserHistory);
        public const string UserLoginHistory = tbl_ + nameof(UserLoginHistory);
        public const string UserRoleHistory = tbl_ + nameof(UserRoleHistory);
        public const string UserTokenHistory = tbl_ + nameof(UserToken);
    }

    // public static class Views
    // {
    //     public const string VwUserWithClaims = nameof(vw_UserWithClaims);
    //     public const string VwDetailedUser = nameof(vw_DetailedUser);
    //     public const string VwRandomBigInt = nameof(vw_getRandomBigInt);
    // }

    // public static class Functions
    // {
    //     public const string FnNewId = nameof(ufn_NewId);
    // }

    public static class Claim
    {
        public static class Columns
        {
            public const string ClaimType = nameof(ClaimType);
            public const string ClaimValue = nameof(ClaimValue);
            public const string Value = nameof(Value);
            public const string Issuer = nameof(Issuer);
            public const string OriginalIssuer = nameof(OriginalIssuer);
            public const string Properties = nameof(Properties);
            public const string StrProperties = _string + nameof(Properties);
            public const string UserId = nameof(UserId);
            public const string ValueType = nameof(ValueType);
            public const string _string = nameof(_string);
            public const string StringClaimType = _string + nameof(Type);
            public const string StringIssuer = _string + nameof(Issuer);
            public const string StringOriginalIssuer = _string + nameof(OriginalIssuer);
            public const string StringValueType = _string + nameof(ValueType);
        }
    }

    public static class User
    {
        public static class Columns
        {
            public const string IsTwoFactorEnabled = nameof(IsTwoFactorEnabled);
            public const string IsPhoneNumberConfirmed = nameof(IsPhoneNumberConfirmed);
            public const string IsEmailConfirmed = nameof(IsEmailConfirmed);
            public const string IsLockoutEnabled = nameof(IsLockoutEnabled);
            public const string Username = nameof(Username);
            public const string EmailAddress = nameof(Email);
            public const string NormalizedUsername = nameof(NormalizedUsername);
            public const string NormalizedEmail = nameof(NormalizedEmail);
            public const string AccessFailedCount = nameof(AccessFailedCount);
            public const string ConcurrencyStamp = nameof(ConcurrencyStamp);
            public const string Email = nameof(Email);
            public const string SecurityStamp = nameof(SecurityStamp);
            public const string PhoneNumber = nameof(PhoneNumber);
            public const string MobilePhoneNumber = nameof(MobilePhoneNumber);
            public const string OtherPhoneNumber = nameof(OtherPhoneNumber);
            public const string LockoutEnd = nameof(LockoutEnd);
            public const string PasswordHash = nameof(PasswordHash);
            public const string GivenName = nameof(GivenName);
            public const string Surname = nameof(Surname);
            public const string StreetAddress = nameof(StreetAddress);
            public const string Locality = nameof(Locality);
            public const string StateOrProvince = nameof(StateOrProvince);
            public const string PostalCode = nameof(PostalCode);
            public const string Gender = nameof(Gender);
            public const string Country = nameof(Country);
            public const string Claims = nameof(Claims);
        }
    }

    public static class RoleClaim
    {
        public const string ClaimType = nameof(ClaimType);
    }

    public static class Columns
    {
        public const string Id = nameof(Id);
        public const string RoleId = nameof(RoleId);
    }
}
