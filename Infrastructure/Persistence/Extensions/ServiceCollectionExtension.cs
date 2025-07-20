using Infrastructure.Audit;
using Infrastructure.Identity;
using Infrastructure.PasswordHasher;
using Infrastructure.Seeders;
using Infrastructure.Seeders.DataSeeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Models.Entities;


namespace Infrastructure.Persistence.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<AuditInterceptor>();
        services.AddHttpContextAccessor();
        services.AddScoped<ICurrentUserService, CurrentUserService>();
        services.AddScoped<MigrationService>();
        services.AddScoped<ISeederService, SeederService>();
        services.AddScoped<IEntitySeederService<User>, UserSeeder>();
        services.AddScoped<IEntitySeederService<Role>, RoleSeeder>();
        services.AddScoped<IEntitySeederService<Project>, ProjectSeeder>();
        services.AddScoped<IPasswordHasher, PasswordHasher.PasswordHasher>();

        services.AddDbContext<AppDbContext>((serviceProvider, options) =>
        {
            var interceptor = serviceProvider.GetRequiredService<AuditInterceptor>();

            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            options.AddInterceptors(interceptor);


        });

        return services;
    }
}
