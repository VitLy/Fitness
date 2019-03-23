using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ServiceLayer.Reposytory
{
    public abstract class BaseRepo<T> where T : class, new()
    {
        public Context Context { get; } = new Context();
        protected DbSet<T> Table;

        public IEnumerable<T> GetAll()
        {
            return Table.ToList<T>();
        }

        public int Add(T enity)
        {
            Table.Add(enity);
            return Context.SaveChanges();
        }

        public T GetOne(int? id)
        {
            if (id == null) throw new ArgumentNullException("Method GetOne() received null argument!!");
            return Table.Find(id);
        }

        public int Delete(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return Context.SaveChanges();
        }

        public int Save(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return Context.SaveChanges();
        }
    }
}


