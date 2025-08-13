using HandsOnFileUploadtoBlobStorage_Demo1.Models;
using HandsOnFileUploadtoBlobStorage_Demo1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnFileUploadtoBlobStorage_Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageController : ControllerBase
    {
        private readonly IAzureStorage _storage;
        private readonly ImageService _imageService;
        public StorageController(IAzureStorage storage)
        {
            _storage = storage;
            _imageService = new ImageService();
        }
        [HttpPost(nameof(Upload))]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            BlobResponseDto? response=await _storage.UploadAsync(file);
            if (response != null)
            {
                _imageService.AddImageUrl(new Image()
                {
                    ImageUrl = response.Blob.Uri
                });
            }

            return StatusCode(StatusCodes.Status200OK, response);
        }
        [HttpGet("GetImageUrls")]
        public IActionResult GetAll()
        {
            List<Image> imagesUrls = _imageService.GetImageUrls();
            return Ok(imagesUrls);
        }
    }
}
