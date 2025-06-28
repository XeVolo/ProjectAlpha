using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Newtonsoft.Json;
using Infrastructure.Persistence;
using Models.Entities;
using Models.Enums;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Audit;

public class AuditInterceptor : SaveChangesInterceptor
{
    private readonly ICurrentUserService _currentUser;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AuditInterceptor(ICurrentUserService currentUser, IHttpContextAccessor httpContextAccessor)
    {
        _currentUser = currentUser;
        _httpContextAccessor = httpContextAccessor;
    }

    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        ProcessAuditLogs(eventData);
        return base.SavingChanges(eventData, result);
    }

    public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default)
    {
        ProcessAuditLogs(eventData);
        return await base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private void ProcessAuditLogs(DbContextEventData eventData)
    {
        var context = eventData.Context;

        if (context == null) return;

        var auditEntries = new List<AuditLog>();

        foreach (var entry in context.ChangeTracker.Entries())
        {
            if (entry.Entity is AuditLog ||
                entry.State == EntityState.Detached ||
                entry.State == EntityState.Unchanged)
                continue;

            var audit = new AuditLog
            {
                Timestamp = DateTime.UtcNow,
                EntityName = entry.Entity.GetType().Name,
                EntityId = TryGetEntityId(entry),
                ActionType = MapStateToActionType(entry.State),
                PerformedByUserId = _currentUser.UserId,
                PerformedByAdminId = _currentUser.AdminId,
                IpAddress = _httpContextAccessor.HttpContext?.Connection?.RemoteIpAddress?.ToString(),
                DeviceInfo = _httpContextAccessor.HttpContext?.Request.Headers["User-Agent"].ToString()
            };

            if (entry.State == EntityState.Modified)
            {
                audit.OldValues = Serialize(entry.OriginalValues);
                audit.NewValues = Serialize(entry.CurrentValues);
            }
            else if (entry.State == EntityState.Added)
            {
                audit.NewValues = Serialize(entry.CurrentValues);
            }
            else if (entry.State == EntityState.Deleted)
            {
                audit.OldValues = Serialize(entry.OriginalValues);
            }

            auditEntries.Add(audit);
        }

        if (auditEntries.Any())
        {
            context.Set<AuditLog>().AddRange(auditEntries);
        }
    }

    private static Guid? TryGetEntityId(EntityEntry entry)
    {
        var property = entry.Properties.FirstOrDefault(p => p.Metadata.IsPrimaryKey());
        return property?.CurrentValue as Guid?;
    }

    private static ActionType MapStateToActionType(EntityState state) => state switch
    {
        EntityState.Added => ActionType.Create,
        EntityState.Modified => ActionType.Update,
        EntityState.Deleted => ActionType.Delete,
        _ => ActionType.None
    };

    private static string Serialize(PropertyValues values) =>
        JsonConvert.SerializeObject(
            values.Properties.ToDictionary(p => p.Name, p => values[p]));
}
