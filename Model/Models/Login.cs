using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Login
    {
        public Guid LoginId { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public User UserId { get; set; }
        public User User { get; set; }

        public Login()
        {

        }
        public Login(string _password,string _username)
        {
            Password = _password;
            Username = _password;
            LoginId = Guid.NewGuid();
        }
    }
}
