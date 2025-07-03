using Infrastructure.Persistence;
using Models.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _db;

    public IUserRepository Users { get; }
    public IAuditLogRepository AuditLogs { get; }
    public IRepository<Role> Roles { get; }

    public UnitOfWork(
        AppDbContext db,
        IUserRepository users,
        IAuditLogRepository auditLogs,
        IRepository<Role> roles)
    {
        _db = db;
        Users = users;
        AuditLogs = auditLogs;
        Roles = roles;
    }

    public Task SaveChangesAsync() => _db.SaveChangesAsync();
}

