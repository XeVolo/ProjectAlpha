using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Extensions;

public class MigrationService(AppDbContext dbContext)
{   

    public async Task ApplyMigrations()
    {

        try
        {
            await dbContext.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd podczas migracji bazy danych: {ex.Message}");
            throw;
        }
    }
}
