using MVC._Data;
using MVC.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MVC.Repository.Interfaces;

namespace MVC.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository()
        {
            _context = new ApplicationDbContext();
        }

        public List<Product> GetAll()
        {
            return _context.Products.Include(p => p.Category).ToList();
        }
    }
}
