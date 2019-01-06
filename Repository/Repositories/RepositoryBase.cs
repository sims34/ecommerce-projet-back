using Repository.Interfaces;
using System;
using System.Collections.Generic;
using Model;
using System.Linq;

namespace Repository
{


    public class RepositoryBase<T> : IRepositoryBase<T> where T : class

    {
        protected readonly AppDbContext _context;
        
        public RepositoryBase(AppDbContext context)
        {
             this._context = context;
        }



        public virtual T Find(Guid id)
        {
            return this._context.Set<T>().Find(id);
        }

        public virtual T FindById(int id)
        {
            return this._context.Set<T>().FirstOrDefault();
        }

        public virtual List<T> GetAll()
        {
            return this._context.Set<T>().ToList();
        }

        public virtual bool Remove(T entity)
        {
             this._context.Set<T>().Remove(entity);
            return true;
        }

        public virtual bool Update(Guid id,T entity)
        {
             this._context.Set<T>().Update(entity);
            return true;
        }
        public virtual void SaveChanges()
        {
            this._context.SaveChanges();
        }
        public virtual void Add(T entity)
        {
             this._context.Set<T>().Add(entity);
        }
    }
}
