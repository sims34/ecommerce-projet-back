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
        
        public void Add(T entity)
        {
             this._context.Set<T>().Add(entity);
        }

        public T Find(Guid id)
        {
            return this._context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return this._context.Set<T>().ToList();
        }

        public Boolean Remove(T entity)
        {
             this._context.Set<T>().Remove(entity);
            return true;
        }

        public Boolean Update(T entity)
        {
             this._context.Set<T>().Update(entity);
            return true;


        }
        public void SaveChanges()
        {
            this._context.SaveChanges();
        }
    }
}
