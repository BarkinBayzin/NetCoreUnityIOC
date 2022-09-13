using System.Collections.Generic;

namespace NetCoreUnityIOC.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        IList<T> GetAll();
        int Save();
    }
}
