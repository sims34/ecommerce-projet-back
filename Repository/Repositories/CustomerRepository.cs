using Model;
using Model.Models;
using Repository;
using Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Service
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {

        public CustomerRepository(AppDbContext context) : base(context)
        {
        }

        public string GetFullName(Customer customer)
        {
            return customer.FullName;
        }

        public override void Add(Customer entity)
        {
            var customer = _context.Customers.Find(entity.UserId);
            if(customer == null)
            {
                base.Add(entity);
                _context.SaveChanges();
            }
            
        }
        public override bool Remove(Customer entity)
        {
            var remove = base.Find(entity.UserId);
            if(remove != null)
            {
                base.Remove(entity);
                base.SaveChanges();
                return true;

            }
            return false;
        }
        public override bool Update(Guid id, Customer entity)
        {
            var UpdateEntity = base.Find(id);
            if (UpdateEntity != null)
            {
                UpdateEntity.FirstName = entity.FirstName;
                UpdateEntity.LastName = entity.LastName;
                UpdateEntity.Address = entity.Address;
                UpdateEntity.Country = entity.Country;
                UpdateEntity.Mail = entity.Mail;
                base.Update(id, UpdateEntity);
                base.SaveChanges();
                return true;
            }
            return false;
        }

        //public bool UpdateLogin(Customer customer)
        //{
        //    var UpdateEntity = base.Find(customer.UserId);
        //    if (UpdateEntity != null)
        //    {
        //        UpdateEntity.Password = customer.Password;
        //        UpdateEntity.Username = customer.Username;
        //        base.Update(customer.UserId, UpdateEntity);
        //        base.SaveChanges();
        //        return true;
        //    }
        //    return false;

        //}
        public bool UpdateStatus(Customer customer)
        {
            var UpdateEntity = base.Find(customer.UserId);
            if (UpdateEntity != null)
            {
                UpdateEntity.Status = customer.Status;
                base.Update(customer.UserId, UpdateEntity);
                base.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
