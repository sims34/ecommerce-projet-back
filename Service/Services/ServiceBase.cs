using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        protected readonly IRepositoryBase<T> _repo;

        public ServiceBase(IRepositoryBase<T> repo)
        {
            this._repo = repo;
        }

        public virtual void Add(T entity)
        {
             this._repo.Add(entity);
        }
        
        public virtual T Find(Guid id)
        {
            return this._repo.Find(id);
        }

        public virtual List<T> GetAll()
        {
            return this._repo.GetAll();
        }

        public virtual bool Remove(T entity)
        {
            this._repo.Remove(entity);
            return true;
        }

        public virtual void SaveChanges()
        {
            this._repo.SaveChanges();
        }

        public virtual bool Update(Guid id,T entity)
        {
            this._repo.Update(id,entity);
            return true;
        }
    }
}
