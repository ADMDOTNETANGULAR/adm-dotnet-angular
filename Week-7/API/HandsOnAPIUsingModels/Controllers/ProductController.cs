using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIUsingModels.Repositories;
using HandsOnAPIUsingModels.Models;
namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController()
        {
            _productRepository = new ProductRepository(); // Initialize the repository
        }
        //define the endpoints for the ProductController
        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            var products = _productRepository.GetAllProducts();
            return Ok(products);
        }
        [HttpGet("GetProductById/{id}")]
        public IActionResult GetProductById(Guid id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound("Invalid Id"); // Return 404 if product not found
            }
            return Ok(product); // Return 200 with product details
        }
        [HttpPost("AddProduct")]
        //[FromBody] is not needed here as the parameter is already bound to the body
        public IActionResult AddProduct([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Product cannot be null"); // Return 400 if product is null
            }
            product.Id = Guid.NewGuid(); // Generate a new Id for the product
            _productRepository.AddProduct(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product); // Return 201 with location of the new resource
        }
        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            if (product == null || product.Id == Guid.Empty)
            {
                return BadRequest("Invalid product data"); // Return 400 if product is null or Id is empty
            }
            var existingProduct = _productRepository.GetProductById(product.Id);
            if (existingProduct == null)
            {
                return NotFound("Product not found and Give id is not valid"); // Return 404 if product does not exist
            }
            _productRepository.UpdateProduct(product);
            return NoContent(); // Return 204 No Content on successful update
        }
        [HttpDelete("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(Guid id)
        {
            var existingProduct = _productRepository.GetProductById(id);
            if (existingProduct == null)
            {
                return NotFound("Product not found and Give id is not valid"); // Return 404 if product does not exist
            }
            _productRepository.DeleteProduct(id);
            return NoContent(); // Return 204 No Content on successful deletion
            //return Ok(new JsonResult("Product deleted successfully")); // Return 200 OK with success message
        }
    }
}
