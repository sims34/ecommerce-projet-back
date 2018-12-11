using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IServiceBase<T> where T : class
    {
        void Add(T entity);

        IEnumerable<T> GetAll();

        T Find(Guid id);

        bool Update(T entity);

        bool Remove(T entity);

        void SaveChanges();
    }
}
