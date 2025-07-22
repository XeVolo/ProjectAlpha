using Media.Helpers;
using Media.Interfaces;
using Media.Services;
using Media.Services.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Media.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMedia(this IServiceCollection services, IConfiguration configuration)
    {

        services.Configure<FileStorageOptions>(
            configuration.GetSection("FileStorage"));


        services.AddScoped<IMediaService, MediaService>();
        services.AddScoped<IFileStorageService, FileStorageService>();

        return services;
    }
}
