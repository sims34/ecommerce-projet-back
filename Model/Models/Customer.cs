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

            public string Password { get; set; }
            public string Username { get; set; }
            public StatusUser Status { get; set; }

            public Customer(string _firstName, string _lastName,string _mail, string _address, string _country, 
                            string _password, string _username, StatusUser _statusUser)
                            : base(_firstName, _lastName)
                              
            {
                Mail = _mail;
                Address = _address;
                Country = _country;
                Password = _password;
                Username = _username;
                Status = _statusUser;
            }
    }
}
