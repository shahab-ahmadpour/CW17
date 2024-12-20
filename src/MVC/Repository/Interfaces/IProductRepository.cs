using MVC.Models;

namespace MVC.Repository.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
    }
}
