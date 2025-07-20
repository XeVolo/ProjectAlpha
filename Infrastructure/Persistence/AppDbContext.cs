using Microsoft.EntityFrameworkCore;
using Models.Entities;


namespace Infrastructure.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User>                  Users       => Set<User>();
    public DbSet<Role>                  Roles       => Set<Role>();
    public DbSet<AuditLog>              AuditLogs   => Set<AuditLog>();
    public DbSet<Project>               Projects    => Set<Project>();
    public DbSet<Conversation>          Conversations => Set<Conversation>();
    public DbSet<Message>               Messages => Set<Message>();
    public DbSet<ProjectFile>           ProjectFiles => Set<ProjectFile>();
    public DbSet<ProjectTask>           ProjectTasks => Set<ProjectTask>();
    public DbSet<ToDoList>              ToDoLists => Set<ToDoList>();
    public DbSet<TaskDistribution>      TaskDistributions => Set<TaskDistribution>();
    public DbSet<Invitation>            Invitations => Set<Invitation>();
    public DbSet<ConversationMember>    ConversationMembers => Set<ConversationMember>();
    public DbSet<ProjectMember>         ProjectMembers => Set<ProjectMember>();














    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
