using System.Text.RegularExpressions;

namespace Dgmjr.Identity.Abstractions;

public interface IHaveATelegramId
{
    long TelegramId { get; }
}
