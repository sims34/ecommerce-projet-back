using Model;
using Model.Models;
using Repository;
using Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;

namespace Service
{
    public class CustomerService : ServiceBase<Customer> ,ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository _cr) : base(_cr)
        {
            this._customerRepository = _cr;
        }

        // add some feature on CRUD method into the service
        public override void Add(Customer entity)
        {
            
        }

        // add CRUD  method
        public string SetNameShort(Customer customer)
        {
            return "Bonjour " + customer.FirstName;
        }
    }

}
