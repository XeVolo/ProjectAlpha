
using Bogus;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Infrastructure.Seeders.DataSeeders;

internal class ProjectSeeder(AppDbContext dbContext) : IEntitySeederService<Project>
{
    private readonly AppDbContext _dbContext = dbContext;

    public async Task SeedAsync()
    {
        if (await _dbContext.Projects.AnyAsync())
        {
            return;
        }

        var faker = new Faker<Project>("pl")
            .RuleFor(p => p.Id, f => f.Random.Guid())
            .RuleFor(p => p.Title, f => f.Company.CatchPhrase())
            .RuleFor(p => p.Description, f => f.Lorem.Paragraphs(1, 2))
            .RuleFor(p => p.StartDate, f => f.Date.Between(DateTime.UtcNow.AddMonths(-3), DateTime.UtcNow))
            .RuleFor(p => p.Deadline, (f, p) => f.Date.Between(p.StartDate.AddDays(1), p.StartDate.AddMonths(6)))
            .RuleFor(p => p.IsActive, f => f.Random.Bool())
            .RuleFor(p => p.IsDeleted, _ => false);

        var projects = faker.Generate(8);

        await _dbContext.Projects.AddRangeAsync(projects);
        await _dbContext.SaveChangesAsync();
    }
}

