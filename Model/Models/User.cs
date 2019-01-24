using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class User
    {
        [Key]
        public Guid   UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        
        public string FullName => $"{FirstName} {LastName}";

        public User()
        {

        }
           
        }
}
