using Media.Helpers;
using Media.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Hosting;

namespace Media.Services.Storage;

public class FileStorageService : IFileStorageService
{
    private readonly string _absolutePath;

    public FileStorageService(IHostEnvironment env, IOptions<FileStorageOptions> options)
    {
        _absolutePath = Path.Combine(env.ContentRootPath, options.Value.RootPath);
        Directory.CreateDirectory(_absolutePath);
    }
    public async Task<string> SaveFileAsync(Stream stream, string extension)
    {
        var guid = Guid.NewGuid().ToString();
        var fileName = $"{guid}{extension}";
        var fullPath = Path.Combine(_absolutePath, fileName);

        using var output = File.Create(fullPath);
        await stream.CopyToAsync(output);

        return fileName;
    }
}


