using Models.Enums;

namespace Models.Entities;
public class Message
{
    public Guid         Id              { get; set; }
    public Guid         ConversationId  { get; set; }
    public Conversation Conversation    { get; set; } = default!;
    public Guid         UserId          { get; set; }
    public User         User            { get; set; } = default!;
    public DateTime     SendTime        { get; set; } = DateTime.UtcNow;
    public string       Content         { get; set; } = string.Empty;
    public bool         IsDeleted       { get; set; } = false;
}
