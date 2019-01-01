using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IServiceBase<T> where T : class
    {
        void Add(T entity);

        List<T> GetAll();

        T Find(Guid id);

        bool Update(Guid id,T entity);

        bool Remove(T entity);

        void SaveChanges();
    }
}
