using Models.Enums;

namespace Models.Entities;
public class Conversation
{
    public Guid                             Id                  { get; set; }
    public string                           Name                { get; set; } = string.Empty;
    public ConversationType                 ConversationType    { get; set; }
    public bool                             IsActive            { get; set; }
    public bool                             IsDeleted           { get; set; } = false;
    public List<ConversationMember>         ConversationMembers { get; set; } = default!;
    public List<Message>                    Messages            { get; set; } = default!;
    public Guid                             ProjectId           { get; set; }
    public Project                          Project             { get; set; } = default!;
}
