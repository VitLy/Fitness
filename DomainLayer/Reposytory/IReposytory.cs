using System.Collections.Generic;

namespace DomainLayer.Reposytory
{
    public interface IReposytory<T>
    {
        IEnumerable<T> GetAll();
        T GetOne(int? id);
        int Add(T entity);
        int Delete(T entity);
        int Save(T entity);
        
    }
}
