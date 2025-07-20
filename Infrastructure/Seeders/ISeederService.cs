namespace Infrastructure.Seeders;

public interface IEntitySeederService<T> where T : class
{
    Task SeedAsync();
}

public interface ISeederService
{
    Task SeedAsync();
}