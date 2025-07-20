using Models.Enums;

namespace Models.Entities;
public class ProjectTask
{
    public Guid                         Id                  { get; set; }
    public DateTime                     CreationDate        { get; set; } = DateTime.UtcNow;
    public DateTime                     Deadline            { get; set; } = DateTime.UtcNow;
    public string                       Title               { get; set; } = string.Empty;
    public string                       Description         { get; set; } = string.Empty;
    public Guid                         UserId              { get; set; }
    public User                         User                { get; set; } = default!;
    public TaskState                    State               { get; set; }
    public TaskPriority                 Priority            { get; set; }
    public Guid                         ToDoListId          { get; set; }
    public ToDoList                     ToDoList            { get; set; } = default!;
    public bool                         IsDeleted           { get; set; } = false;
    public List<TaskDistribution>       TasksDistributions  { get; set; } = default!;
}
