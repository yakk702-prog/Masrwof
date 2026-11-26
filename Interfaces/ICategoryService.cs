using Masrwof.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masrwof.Interfaces
{
    public interface ICategoryService
    {
        Category GetCategoryById(Guid id);
        void UpdateCategory(Category category);
        List<Category> GetAllCategories();
        void AddCategory(Category category);
        void DeleteCategory(Guid id);
    }
}
