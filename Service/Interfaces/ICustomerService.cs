using Model.Models;
using Repository;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface ICustomerService : IServiceBase<Customer>
    {
        // method relative to service 
        String SetNameShort(Customer customer);
    }
}
