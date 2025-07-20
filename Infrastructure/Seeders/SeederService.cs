using Microsoft.Extensions.Hosting;
using Models.Entities;
using System.Security;

namespace Infrastructure.Seeders;

internal class SeederService(IHostEnvironment environment,
    IEntitySeederService<User> userSeeder,
    IEntitySeederService<Role> roleSeeder,
    IEntitySeederService<Project> projectSeeder) : ISeederService
{
    public async Task SeedAsync()
    {
        await roleSeeder.SeedAsync();

        if (environment.IsDevelopment())
        {
            await userSeeder.SeedAsync();
            await projectSeeder.SeedAsync();
        }
    }
}

