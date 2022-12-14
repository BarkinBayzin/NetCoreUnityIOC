using NetCoreUnityIOC.Context;
using NetCoreUnityIOC.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreUnityIOC.Repositories
{
    public class SupplierRepository : IRepository<Supplier>
    {
        private readonly ProjectContext _db;

        public SupplierRepository(ProjectContext db)
        {
            _db = db;
        }

        public void Add(Supplier entity)
        {
            _db.Suppliers.Add(entity);
        }

        public IList<Supplier> GetAll()
        {
            var supplierList = _db.Suppliers.ToList();

            return supplierList;
        }

        public int Save()
        {
            return _db.SaveChanges();
        }
    }
}
