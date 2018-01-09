using System;
using System.Collections.Generic;
using LokateApi.DTO;
using Neo4jClient;

namespace LokateApi.DAL
{
    public class CategoriesRepository : GraphRepository, ICategoriesRepository
    {
        public CategoriesRepository(IGraphClient graphClient) : base(graphClient)
        {
        }

        public void DeleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }

        public Category GetCategoryById(int categoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetCategories()
        {
            return GraphClient.Cypher
                .Match("(c:Category)")
                .Return(category => category.As<Category>())
                .Results;
        }

        public void InsertCategory(Category category)
        {
            GraphClient.Cypher
                .Create("(c:Category {category})")
                .WithParams(new { category })
                .ExecuteWithoutResults();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
