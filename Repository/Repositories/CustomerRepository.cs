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

        public string GetFullName(User customer)
        {
            return customer.FullName;
        }

        public override void Add(Customer entity)
        {
           
        }

    }
}
