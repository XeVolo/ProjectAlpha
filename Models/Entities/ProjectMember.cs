using Models.Enums;

namespace Models.Entities;
public class ProjectMember
{
    public Guid                 Id          { get; set; }
    public Guid                 ProjectId   { get; set; }
    public Project              Project     { get; set; } = default!;
    public Guid                 UserId      { get; set; }
    public User                 User        { get; set; } = default!;
    public ProjectMemberRole    Role        { get; set; }
}
