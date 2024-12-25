using MVC.Models;
using MVC.Repository;
using MVC.Repository.Interfaces;
using MVC.Services.Interfaces;

namespace MVC.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

    }
}
