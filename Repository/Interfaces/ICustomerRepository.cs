using Model.Models;
using Repository;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface ICustomerRepository : IRepositoryBase<Customer>
    {
        //set specific method to Customer service
        Customer GetCustomerByName(String name);
    }
}
