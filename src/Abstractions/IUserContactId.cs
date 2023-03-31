namespace Dgmjr.Identity.Abstractions;

public interface IUserContactId : IUserAssociatedEntity
{
    long BotId { get; set; }
    ObjectId ContactId { get; set; }
}
