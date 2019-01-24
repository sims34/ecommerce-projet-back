using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models
{
    public class Login
    {
        [Key]
        public Guid LoginId { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        //[ForeignKey("Customer")]
        //public Guid CustomerId { get; set; }
        //public Customer Customer { get; set; }

        public Login()
        {

         }
            
        }
}
