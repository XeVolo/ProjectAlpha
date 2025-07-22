
namespace Media.Interfaces;

public interface IFileStorageService
{
    Task<string> SaveFileAsync(Stream stream, string extension);
}
