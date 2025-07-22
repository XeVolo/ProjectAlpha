namespace Media.Interfaces;

public interface IMediaService
{
    Task<string> UploadImageAsync(Stream fileStream, string extension);
}
