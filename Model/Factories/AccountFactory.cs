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
            var johnSmith = new Customer("John", "Smith", "smith@john.com", "2 Avenue NEW-YORK, USA", "USA",StatusUser.Active);

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
