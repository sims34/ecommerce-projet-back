using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    public class User
    {
        [Key]
        public Guid   UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        //public  Account Account { get; set; }
    }
}
