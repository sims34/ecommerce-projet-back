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

       
    }

}
