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

        public Customer GetCustomerByName(string name)
        {
            return null;
        }
    }
}
