using Models.Enums;

namespace Models.Entities;
public class User
{
    public Guid                     Id                  { get; set; }
    public string                   Username            { get; set; } = string.Empty;
    public string                   Email               { get; set; } = string.Empty;
    public string                   PasswordHash        { get; set; } = string.Empty;
    public bool                     IsActive            { get; set; } = true;
    public DateTime                 RegisteredAt        { get; set; } = DateTime.UtcNow;
    public string?                  RefreshToken        { get; set; }
    public DateTime?                RefreshTokenExpires { get; set; }
    public string                   FirstName           { get; set; } = string.Empty;
    public string                   LastName            { get; set; } = string.Empty;
    public DateTime?                DateOfBirth         { get; set; }
    public bool                     IsDeleted           { get; set; } = false;
    public Guid                     RoleId              { get; set; }
    public Role                     Role                { get; set; } = null!;
    public List<ProjectMember>      ProjectMembers      { get; set; } = default!; 
    public List<Message>            Messages            { get; set; } = default!;
    public List<ProjectFile>        ProjectFiles        { get; set; } = default!;
    public List<ProjectTask>        ProjectTasks        { get; set; } = default!;
    public List<ConversationMember> ConversationMembers { get; set; } = default!;
    public List<ToDoList>           ToDoLists           { get; set; } = default!;
    public List<TaskDistribution>   TaskDistributions   { get; set; } = default!;
    public List<Invitation>         Invitations         { get; set; } = default!;

}
