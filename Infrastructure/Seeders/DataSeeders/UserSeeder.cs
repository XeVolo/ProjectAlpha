using Infrastructure.PasswordHasher;
using Infrastructure.Persistence;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Bogus;


namespace Infrastructure.Seeders.DataSeeders;

public class UserSeeder(AppDbContext dbContext, IPasswordHasher passwordHasher) : IEntitySeederService<User>
{
    private const string Locale = "pl";
    private readonly AppDbContext _dbContext = dbContext;

    public async Task SeedAsync()
    {
        if (await _dbContext.Users.AnyAsync())
        {
            return;
        }

        var userRole = _dbContext.Roles.FirstOrDefault(r => r.Name == "User");

        if (userRole is null)
        {
            return;
        }

        var passwordHash = passwordHasher.Hash("SecretPassword123#");

        var faker = new Faker<User>(Locale)
            .RuleFor(u => u.Id, f => f.Random.Guid())
            .RuleFor(u => u.Username, f => f.Internet.UserName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.PasswordHash, _ => passwordHash)
            .RuleFor(u => u.IsActive, f => f.Random.Bool())
            .RuleFor(u => u.RegisteredAt, f =>
                DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc))
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.DateOfBirth, f =>
                DateTime.SpecifyKind(
                    f.Date.Between(new DateTime(1990, 1, 1), new DateTime(2010, 12, 31)),
                    DateTimeKind.Utc))
            .RuleFor(u => u.IsDeleted, f => false)
            .RuleFor(u => u.RoleId, _ => userRole.Id)
            .RuleFor(u => u.Role, _ => userRole);

        var users = faker.Generate(10);

        await _dbContext.Users.AddRangeAsync(users);
        await _dbContext.SaveChangesAsync();
    }
}

