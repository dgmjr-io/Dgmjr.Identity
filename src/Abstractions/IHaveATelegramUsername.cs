namespace Dgmjr.Identity.Abstractions;

public interface IHaveATelegramUsername
{
    /// <summary>Gets or sets the user's unique Telegram username</summary>
    /// <example>@IAmTheAntitwink</example>
    [
        RegularExpression(Account.UsernameRegex),
        Column(nameof(TelegramUsername), TypeName = DbTypeVarChar.ShortName)
    ]
    string TelegramUsername { get; set; }
}
