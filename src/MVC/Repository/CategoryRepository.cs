using MVC._Data;
using MVC.Models;
using MVC.Repository.Interfaces;

namespace MVC.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository()
        {
            _context = new ApplicationDbContext();
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
        public Category GetById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }
        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
        public void Update(Category category)
        {
            var existingCategory = _context.Categories.FirstOrDefault(c => c.Id == category.Id);
            if (existingCategory != null)
            {
                existingCategory.Name = category.Name;
                _context.SaveChanges();
            }
        }


    }
}
