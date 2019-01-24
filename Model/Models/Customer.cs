using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models
{
        public enum StatusUser
        {
            New,
            Active,
            Blocked,
            Banned,
            Admin
        }
        public class Customer : User
        {
            public string Mail { get; set; }
            public string Address { get; set; }
            public string Country { get; set; }
            
            public StatusUser Status { get; set; }

            //public Guid LoginId { get; set; }
          public  Login Login { get; set; }

        //[ForeignKey("Account")]
        //public Guid AccountId { get; set; }
        public  Account Account { get; set; }

            public Customer()
            {

            }
          
    }
}
