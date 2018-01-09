using System;
using System.Collections.Generic;
using LokateApi.DTO;

namespace LokateApi.DAL
{
    public interface ICategoriesRepository : IDisposable
    {
        IEnumerable<Category> GetCategories();
        Category GetCategoryById(int CategoryId);
        void InsertCategory(Category student);
        void DeleteCategory(int CategoryId);
        void UpdateCategory(Category student);
        void Save();
    }
}
