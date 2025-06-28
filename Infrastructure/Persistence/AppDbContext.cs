using Microsoft.EntityFrameworkCore;
using Models.Entities;


namespace Infrastructure.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User>      Users       => Set<User>();
    public DbSet<Role>      Roles       => Set<Role>();
    public DbSet<AuditLog>  AuditLogs   => Set<AuditLog>();



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
