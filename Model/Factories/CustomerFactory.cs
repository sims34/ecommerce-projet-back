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
            new Customer("John", "Malkovitch","abc@gmail.com","5 AV NEW-YORK","USA","123","sims", StatusUser.New),
      
            new Customer("Brad", "Pitt","abc@gmail.com","5 AV LOS-YORK","FR","123","sims", StatusUser.Active),
           
            new Customer("Jessica", "Alba","abc@gmail.com","5 AV PARIS-YORK","GER","123","sims", StatusUser.Blocked),
           
            new Customer("Jessica", "Alba","abc@gmail.com","5 AV PARIS-YORK","GER","123","sims", StatusUser.Blocked),

            new Customer("Admin", "User","abc@gmail.com","5 AV PARIS-YORK","GER","admin","admin", StatusUser.Admin),

        };
    }
}
