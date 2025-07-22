using Media.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media.Services;

public class MediaService : IMediaService
{
    private readonly IFileStorageService _fileStorage;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public MediaService(
        IFileStorageService fileStorage,
        IHttpContextAccessor httpContextAccessor)
    {
        _fileStorage = fileStorage;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<string> UploadImageAsync(Stream fileStream, string extension)
    {
        var fileName = await _fileStorage.SaveFileAsync(fileStream, extension);

        var request = _httpContextAccessor.HttpContext?.Request;

        if (request == null)
            throw new InvalidOperationException("Unable to resolve HTTP context");

        var baseUrl = $"{request.Scheme}://{request.Host}";
        var imageUrl = $"{baseUrl}/media/images/{fileName}";

        return imageUrl;
    }
}
