using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Factories
{
    public class LoginFactory
    {
        public static Login[] DefaultLogin = new Login[]
        {
           new Login("toto", "tara"),
            new Login("123", "toto"),
             new Login("admin", "admin"),
        };
    }
}
