using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        protected IRepositoryBase<T> _repo;

        public ServiceBase(IRepositoryBase<T> repo)
        {
            this._repo = repo;
        }

        public virtual void Add(T entity)
        {
            this._repo.Add(entity);
        }

        public T Find(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
