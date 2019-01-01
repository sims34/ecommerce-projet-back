using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{

    class Login
    {
        public Guid LoginId {get; set; }
        public Guid UserId { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
       // enum state to implemente
    }
}
