using Models.Enums;

namespace Models.Entities;
public class TaskDistribution
{
    public Guid         Id      { get; set; }
    public Guid         TaskId  { get; set; }
    public ProjectTask  Task    { get; set; } = default!;
    public Guid         UserId  { get; set; }
    public User         User    { get; set; } = default!;
}
