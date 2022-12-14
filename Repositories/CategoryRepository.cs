using NetCoreUnityIOC.Context;
using NetCoreUnityIOC.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreUnityIOC.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly ProjectContext _db;

        public CategoryRepository(ProjectContext db)
        {
            _db = db;
        }

        public void Add(Category entity)
        {
            _db.Categories.Add(entity);
        }

        public IList<Category> GetAll()
        {
            var categoryList = _db.Categories.ToList();
            return categoryList;
        }

        public int Save()
        {
            return _db.SaveChanges();
        }
    }
}
