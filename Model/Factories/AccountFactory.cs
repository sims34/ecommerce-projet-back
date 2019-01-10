using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Factories
{
    class AccountFactory
    {
        
        public static Account[] DefaultAccount()
        {
            var johnSmith = new User
            {
                UserId = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Smith",
                Mail = "smith@john.com",
                Address = "2 Avenue NEW-YORK, USA",
                Country = "USA"
            };
            Account[] Data = new Account[]
            {
                new Account
                {
                    IdAccount =Guid.NewGuid(),
                    BillAddress = "5 Avenue NEW-YORK, USA",
                    IsClosed = true,
                    Open = DateTime.Today,
                    Closed = new DateTime(2020, 12, 31),
                    UserId = johnSmith.UserId
                },
                new Account
                {
                    IdAccount =Guid.NewGuid(),
                    BillAddress = "2 Avenue NEW-YORK, USA",
                    IsClosed = true,
                    Open = DateTime.Today,
                    Closed = new DateTime(2020, 12, 31),
                    UserId = johnSmith.UserId
                },
                new Account
                {
                    IdAccount =Guid.NewGuid(),
                    BillAddress = "4 Avenue NEW-YORK, USA",
                    IsClosed = true,
                    Open = DateTime.Today,
                    Closed = new DateTime(2020, 12, 31),
                    UserId = johnSmith.UserId
                },

            };

            return Data;
        }
            

    }
}
