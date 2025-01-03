﻿using MVC.Models;
using MVC.Repository;
using MVC.Repository.Interfaces;
using MVC.Services.Interfaces;

namespace MVC.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }
        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetById(id);
        }
        public void AddCategory(Category category)
        {
            _categoryRepository.Add(category);
        }
        public void UpdateCategory(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
