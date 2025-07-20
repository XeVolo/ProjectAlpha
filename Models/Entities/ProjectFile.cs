using Models.Enums;

namespace Models.Entities;
public class ProjectFile
{
    public Guid         Id              { get; set; }
    public string       FileName        { get; set; } = string.Empty;
    public string       FileStorageUrl  { get; set; } = string.Empty;
    public string       ContentType     { get; set; } = string.Empty;
    public int          FileSize        { get; set; }
    public DateTime     UploadDate      { get; set; } = DateTime.UtcNow;
    public bool         IsDeleted       { get; set; } = false;
    public Guid         UserId          { get; set; }
    public User         User            { get; set; } = default!;
    public Guid         ProjectId       { get; set; }
    public Project      Project         { get; set; } = default!;
}
