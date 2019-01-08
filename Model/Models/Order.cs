using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Order
    {
        public int IdOrder { get; set; }
        public Account Account { get; set; }
        public Basket Basket { get; set; }
        public Status OrderStatus { get; set; }

    }
}
