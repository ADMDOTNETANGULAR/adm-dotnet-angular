using HandsOnFileUploadtoBlobStorage_Demo1.Models;

namespace HandsOnFileUploadtoBlobStorage_Demo1.Services
{
    public interface IAzureStorage
    {
        Task<BlobResponseDto> UploadAsync(IFormFile file);
    }
}
