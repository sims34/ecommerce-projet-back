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
            var johnSmith = new Customer("John", "Smith", "smith@john.com", "2 Avenue NEW-YORK, USA", "USA", StatusUser.Active);


            entityBuilder.Entity<Customer>().HasData(johnSmith);

            entityBuilder.Entity<Account>().HasData(
            new Account
            {
                IdAccount = Guid.NewGuid(),
                BillAddress = "5 Avenue NEW-YORK, USA",
                IsClosed = true,
                Open = DateTime.Today,
                Closed = new DateTime(2020, 12, 31),
                UserId = johnSmith.UserId
            });
        }
       
    }
}
