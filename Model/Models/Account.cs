using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models
{
    public class Account
    {
        [Key]
        [ForeignKey("User")]
        public Guid IdAccount { get; set; }
        
        public string BillAddress { get; set; }
        public bool IsClosed { get; set; }
        public DateTime Open { get; set; }
        public DateTime Closed { get; set; }

        public virtual User User { get; set; }
    }
}
