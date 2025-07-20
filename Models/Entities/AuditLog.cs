using Models.Enums;

namespace Models.Entities;
public class AuditLog
{
    public Guid         Id                  { get; set; }
    public DateTime     Timestamp           { get; set; } = DateTime.UtcNow;
    public string       EntityName          { get; set; } = string.Empty;
    public Guid?        EntityId            { get; set; }
    public ActionType   ActionType          { get; set; }
    public string?      OldValues           { get; set; }
    public string?      NewValues           { get; set; }
    public Guid?        PerformedByUserId   { get; set; }
    public Guid?        PerformedByAdminId  { get; set; }
    public string?      IpAddress           { get; set; }
    public string?      DeviceInfo          { get; set; }
    public bool         IsDeleted           { get; set; } = false;
}
