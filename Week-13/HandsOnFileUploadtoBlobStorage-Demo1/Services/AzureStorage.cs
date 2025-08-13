using Azure.Storage.Blobs;
using HandsOnFileUploadtoBlobStorage_Demo1.Models;
using System.Reflection.Metadata;

namespace HandsOnFileUploadtoBlobStorage_Demo1.Services
{
    public class AzureStorage : IAzureStorage
    {
        private readonly string _storageConnectionString;
        private readonly string _storageContainerName;
        public AzureStorage(IConfiguration configuration)
        {
            _storageConnectionString = configuration.GetValue<string>("BlobConnectionString");
            _storageContainerName = configuration.GetValue<string>("BlobContainerName");
        }
        public async Task<BlobResponseDto> UploadAsync(IFormFile file)
        {
            BlobResponseDto response = new BlobResponseDto();
            BlobContainerClient container = new BlobContainerClient(_storageConnectionString, _storageContainerName);
            try
            {
                BlobClient client = container.GetBlobClient(file.FileName);
                await using (Stream? data = file.OpenReadStream())
                {
                    await client.UploadAsync(data);
                }
                response.Status = $"File {file.FileName} uploaded successfully!!!";
                response.Error = false;
                response.Blob.Uri = client.Uri.AbsoluteUri;
                response.Blob.Name = client.Name;
            }
            catch (Exception ex)
            {

            }
            return response;
        }
    }
}
