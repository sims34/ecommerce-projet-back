using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }
        public virtual Customer  Customer { get; set; }

        //public Guid BasketId { get; set; }
        public  Basket Basket { get; set; }
    }
}
