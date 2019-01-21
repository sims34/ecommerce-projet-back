using Microsoft.EntityFrameworkCore;
using Model.Factories;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SeedContextCustomer
    {
        public SeedContextCustomer(ModelBuilder entityBuilder)
        {
            entityBuilder.Entity<Customer>().HasData(CustomerFactory.DefaultCustomer);
        }
    }
}
