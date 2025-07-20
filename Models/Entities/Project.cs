using Models.Enums;

namespace Models.Entities;
public class Project
{
    public Guid                             Id          { get; set; }
    public string                           Title       { get; set; } = string.Empty;
    public DateTime                         StartDate   { get; set; }
    public DateTime                         Deadline    { get; set; }
    public string                           Description { get; set; } = string.Empty;
    public bool                             IsActive    { get; set; }
    public bool                             IsDeleted   { get; set; } = false;

}
