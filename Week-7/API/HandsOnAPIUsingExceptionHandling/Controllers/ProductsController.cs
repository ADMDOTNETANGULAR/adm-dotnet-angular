using HandsOnAPIUsingExceptionHandling.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingExceptionHandling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly List<string> _products = new() { "Book", "Pen", "Laptop" };
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            if (id < 0 || id >= _products.Count)
            {
                throw new NotFoundException("Product not found");
            }

            return Ok(_products[id]);
        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            try
            {
                if (_products.Count < 10)
                {
                    throw new NotFoundException("No products available");
                }
                return Ok(_products);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("error")]
        public IActionResult ThrowError()
        {
            throw new Exception("This is an unhandled exception");
        }
    }
}
