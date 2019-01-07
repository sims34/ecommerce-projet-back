using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Order
    {
        public int IdOrder { get; set; }
        public Account Account { get; set; }
        public List<BasketItems> Basket { get; set; }
        public Status OrderStatus { get; set; }

    }
}
