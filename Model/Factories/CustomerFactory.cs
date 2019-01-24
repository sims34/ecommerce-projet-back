using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Factories
{
    public class CustomerFactory
    {

        public static Customer[] DefaultCustomer = new Customer[]
        {
            new Customer
            {
                UserId = Guid.NewGuid(),
                FirstName = "JOJO",
                LastName = "Smith",
                Mail = "smith@john.com",
                Address = "2 Avenue NEW-YORK, USA",
                Country = "USA",
                Status = StatusUser.Active,

            },
             new Customer
            {
                UserId = Guid.NewGuid(),
                FirstName = "MAMA",
                LastName = "Smith",
                Mail = "smith@john.com",
                Address = "2 Avenue NEW-YORK, USA",
                Country = "USA",
                Status = StatusUser.Active,

            },
              new Customer
            {
                UserId = Guid.NewGuid(),
                FirstName = "MAMI",
                LastName = "Smith",
                Mail = "smith@john.com",
                Address = "2 Avenue NEW-YORK, USA",
                Country = "USA",
                Status = StatusUser.Active,

            },
               new Customer
            {
                UserId = Guid.NewGuid(),
                FirstName = "JAJAJ",
                LastName = "Smith",
                Mail = "smith@john.com",
                Address = "2 Avenue NEW-YORK, USA",
                Country = "USA",
                Status = StatusUser.Active,

            },


    };
    }
}
