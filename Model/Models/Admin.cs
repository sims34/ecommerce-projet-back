using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Admin : User
    {
        public Admin(string _firstName,string _lastName) : base(_firstName, _lastName) { }
    }
}
