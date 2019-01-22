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
       
        public string FullName => $"{FirstName} {LastName}";

        public User()
        {

        }
        public User(string _firstName, string _lastName)
        {
            FirstName = _firstName;
            LastName = _firstName;
        }
    }
}
