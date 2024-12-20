using MVC.Models;

namespace MVC.Services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
    }
}
