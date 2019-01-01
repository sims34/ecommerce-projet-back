using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        T GetById(int id);
       
        void Add(T entity);

        List<T> GetAll();

        T Find(Guid id);

        bool Update(Guid id,T entity);

        bool Remove(T entity);

        void SaveChanges();
       
    }
}
