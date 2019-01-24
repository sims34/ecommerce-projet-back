using Microsoft.EntityFrameworkCore;
using Model.Factories;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SeedContextLogin
    {
        public SeedContextLogin(ModelBuilder entityBuilder)
        {

            var login = new Login
            {
                LoginId = Guid.NewGuid(),
                Password = "admin",
                Username = "admin"
            };
            entityBuilder.Entity<Login>().HasData(login);

            //var user = new Customer
            //{
            //    FirstName = "John",
            //    LastName = "Malkovitch",
            //    Mail = "abc@gmail.com",
            //    Address = "5 AV NEW-YORK",
            //    Country = "USA",
            //    Status = StatusUser.New,
            //    LoginId = login.LoginId
            //}; 

            //entityBuilder.Entity<Customer>().HasData(user);

            //entityBuilder.Entity<Customer>()
            //     .HasOne(u => u.Login)
            //     .WithOne( l => l.Customer)
            //     .HasForeignKey<Login>(b => b.LoginId);

            //entityBuilder.Entity<Login>()
            //     .HasOne( l=> l.Customer)
            //     .WithOne(u => u.Login)
            //     .HasForeignKey<Customer>(b => b.UserId); 
        }
    }
}
