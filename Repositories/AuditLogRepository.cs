using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Repositories.Base;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories;
public class AuditLogRepository : Repository<AuditLog>, IAuditLogRepository
{
    public AuditLogRepository(AppDbContext db) : base(db) { }

    public async Task<IEnumerable<AuditLog>> GetByEntityAsync(string entityName, Guid? entityId)
    {
        return await _set
            .Where(a => a.EntityName == entityName && a.EntityId == entityId)
            .OrderByDescending(a => a.Timestamp)
            .ToListAsync();
    }

    public async Task<IEnumerable<AuditLog>> GetByUserAsync(Guid userId)
    {
        return await _set
            .Where(a => a.PerformedByUserId == userId)
            .OrderByDescending(a => a.Timestamp)
            .ToListAsync();
    }

    public async Task<IEnumerable<AuditLog>> GetRecentAsync(int count)
    {
        return await _set
            .OrderByDescending(a => a.Timestamp)
            .Take(count)
            .ToListAsync();
    }
}

