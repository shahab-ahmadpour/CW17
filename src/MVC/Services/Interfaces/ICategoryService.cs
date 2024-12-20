using MVC.Models;

namespace MVC.Services.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
    }
}
