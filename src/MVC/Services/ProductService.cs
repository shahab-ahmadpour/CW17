using MVC.Models;
using MVC.Repository;
using MVC.Repository.Interfaces;
using MVC.Services.Interfaces;

namespace MVC.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

    }
}
