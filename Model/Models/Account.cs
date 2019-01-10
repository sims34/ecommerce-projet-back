using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    public class Account
    {
        [Key]
        public Guid IdAccount { get; set; }
        public string BillAddress { get; set; }
        public bool IsClosed { get; set; }
        public DateTime Open { get; set; }
        public DateTime Closed { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
