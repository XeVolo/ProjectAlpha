using Models.Enums;

namespace Models.Entities;
public class ConversationMember
{
    public Guid         Id              { get; set; }
    public Guid         UserId          { get; set; }
    public User         User            { get; set; } = default!;
    public Guid         ConversationId  { get; set; }
    public Conversation Conversation    { get; set; } = default!;
    public bool         IsDeleted       { get; set; } = false;
}
