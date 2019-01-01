using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Order
    {
        public Guid IdOrder { get; set; }
        public Basket card { get; set; }
        public DateTime Shipped { get; set; }
        public Status OrderStatus { get; set; }

    }
}
