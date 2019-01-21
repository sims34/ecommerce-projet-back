using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    public class User
    {
        [Key]
        protected Guid   UserId { get; set; }
        protected String FirstName { get; set; }
        protected String LastName { get; set; }
       
        public string FullName => $"{FirstName} {LastName}";
        
        public User(string _firstName, string _lastName)
        {
            UserId = Guid.NewGuid();
            FirstName = _firstName;
            LastName = _firstName;
        }
    }
}
