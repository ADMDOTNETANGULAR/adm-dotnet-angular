using HandsOnMVCUsingEF.Repositories;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingEF.Entities;
using HandsOnMVCUsingEF.Models;
using HandsOnMVCUsingEF.DBContext;
namespace HandsOnMVCUsingEF.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductContract _productRepository;
        public ProductController()
        {
            _productRepository = new ProductRepository();
        }
        public IActionResult Index()
        {
          List<Product> products = _productRepository.GetAllProductsAsync().Result;
            // Convert to ProductDto if needed
            List<ProductDto> productDtos = products.Select(p => new ProductDto
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                Price = p.Price,
                Quantity = p.Quantity
            }).ToList();
            return View(productDtos);
        }
        public async Task<IActionResult> Details(int id)
        {
            // Logic to fetch product details by id
            Product product = await _productRepository.GetProductByIdAsync(id);
            // Convert to ProductDto if needed
            if(product == null)
            {
                return View(null);
            }
            ProductDto productDto = new ProductDto
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Price = product.Price,
               // Quantity = product.Quantity
            };
            return View(productDto);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public  async Task<IActionResult> Add(ProductDto productDto)
        {
            //Convert ProductDto to Product entity
            Product product = new Product
            {
                ProductId = productDto.ProductId,
                ProductName = productDto.ProductName,
                Price = productDto.Price,
                Quantity = productDto.Quantity
            };
            // Call the repository to add the product
            await _productRepository.AddProductAsync(product);
            // Redirect to the index action to see the updated list
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            // Logic to fetch product details by id for confirmation
          await _productRepository.DeleteProductAsync(id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            // Logic to fetch product details by id for editing
            Product product = await _productRepository.GetProductByIdAsync(id);
           
            // Convert to ProductDto if needed
            ProductDto productDto = new ProductDto
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Price = product.Price,
                Quantity = product.Quantity
            };
            return View(productDto);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductDto productDto)
        {
            // Convert ProductDto to Product entity
            Product product = new Product
            {
                ProductId = productDto.ProductId,
                ProductName = productDto.ProductName,
                Price = productDto.Price,
                Quantity = productDto.Quantity
            };
            // Call the repository to update the product
            await _productRepository.UpdateProductAsync(product);
            // Redirect to the index action to see the updated list
            return RedirectToAction("Index");
        }
    }
}
