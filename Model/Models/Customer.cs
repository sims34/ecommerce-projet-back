using System;
using System.Collections.Generic;
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
            public  Login LoginId { get; set; }
            public Login Login { get; set; }
            public StatusUser Status { get; set; }
            
            
            public Customer(string _firstName, string _lastName,string _mail, string _address, string _country, StatusUser _statusUser)
                            : base(_firstName, _lastName)
                              
            {
                Mail = _mail;
                Address = _address;
                Country = _country;
                Status = _statusUser;
                UserId = Guid.NewGuid();
            }
    }
}
