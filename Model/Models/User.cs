using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }

        public virtual Account Account { get; set; }
    }
}
