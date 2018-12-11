using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Seller : User
    {
        public String SocietyName { get; set; }
        public List<Article> Articles { get; set; }

    }
}
