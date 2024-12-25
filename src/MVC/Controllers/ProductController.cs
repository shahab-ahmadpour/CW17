using Microsoft.AspNetCore.Mvc;
using MVC._Data;
using MVC.Repository;
using MVC.Services;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController()
        {
            var dbContext = new ApplicationDbContext();
            var productRepository = new ProductRepository(dbContext);
            _productService = new ProductService(productRepository);
        }

        public IActionResult Index()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }
    }

}
