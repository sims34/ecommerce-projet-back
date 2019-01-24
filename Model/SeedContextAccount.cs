using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Factories;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SeedContextAccount
    {
        public SeedContextAccount(ModelBuilder entityBuilder)
        {
            var johnSmith = new Customer
            {
                UserId = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Smith",
                Mail = "smith@john.com",
                Address = "2 Avenue NEW-YORK, USA",
                Country = "USA",
                Status = StatusUser.Active,
                
            };

            entityBuilder.Entity<Customer>().HasData(johnSmith);

            var login = new Login
            {
                LoginId = Guid.NewGuid(),
                Password = "admin",
                Username = "admin",
                Customer = johnSmith
            };

           
            entityBuilder.Entity<Login>().HasData(login);
            var account = new Account
            {
                IdAccount = Guid.NewGuid(),
                BillAddress = "5 avenue new-york, usa",
                IsClosed = true,
                Open = DateTime.Today,
                Closed = new DateTime(2020, 12, 31),
                Customer = johnSmith,
            };

           
            entityBuilder.Entity<Account>().HasData(account);




        }
    }
}
