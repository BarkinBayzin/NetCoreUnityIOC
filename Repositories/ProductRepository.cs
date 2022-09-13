using Microsoft.EntityFrameworkCore;
using NetCoreUnityIOC.Context;
using NetCoreUnityIOC.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreUnityIOC.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly ProjectContext _db;

        public ProductRepository(ProjectContext db)
        {
            _db = db;
        }

        public void Add(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            var productList = _db.Products.Include(x => x.Category).Include(x => x.Supplier).ToList();

            return productList;
        }

        public int Save()
        {
            throw new System.NotImplementedException();
        }
    }
}
