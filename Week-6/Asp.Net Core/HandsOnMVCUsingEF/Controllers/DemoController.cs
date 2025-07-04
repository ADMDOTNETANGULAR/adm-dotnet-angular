using HandsOnMVCUsingEF.DBContext;
using HandsOnMVCUsingEF.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingEF.Controllers
{
    public class DemoController : Controller
    {
        private readonly OnlineShopContext _context;
        public DemoController()
        {
            _context = new OnlineShopContext();
        }
        public IActionResult Index() //Get All Products
        {
            var products = _context.Products.ToList();
            return View(products);
        }
        public IActionResult Details(int id) //Get Product by Id
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        // Create Product
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
