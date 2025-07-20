using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Seeders.DataSeeders;

internal class RoleSeeder(AppDbContext dbContext) : IEntitySeederService<Role>
{
    private readonly AppDbContext _dbContext = dbContext;

    public async Task SeedAsync()
    {
        if (await _dbContext.Roles.AnyAsync())
        {
            return;
        }

        var roles = new List<Role>
        {
            new Role
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                IsDeleted = false,
                Users = new List<User>()
            },
            new Role
            {
                Id = Guid.NewGuid(),
                Name = "User",
                IsDeleted = false,
                Users = new List<User>()
            },
            new Role
            {
                Id = Guid.NewGuid(),
                Name = "Manager",
                IsDeleted = false,
                Users = new List<User>()
            }
        };

        await _dbContext.Roles.AddRangeAsync(roles);
        await _dbContext.SaveChangesAsync();
    }
}
