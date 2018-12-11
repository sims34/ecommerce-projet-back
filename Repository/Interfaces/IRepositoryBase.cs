using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T entity);

        IEnumerable<T> GetAll();

        T Find(Guid id);

         bool Update(T entity);

         bool Remove(T entity);

        void SaveChanges();
    }
}
