using Models.Enums;

namespace Models.Entities;
public class ToDoList
{
    public Guid                 Id          { get; set; }
    public Guid                 ProjectId   { get; set; }
    public Project              Project     { get; set; } = default!;
    public List<ProjectTask>    Tasks       { get; set; } = default!;
}
