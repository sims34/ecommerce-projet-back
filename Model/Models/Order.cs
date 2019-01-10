using System;

namespace Model.Models
{
    public class Order
    {
        public Guid IdOrder { get; set; }
        public Account Account { get; set; }
        public  Basket Basket { get; set; }
        public StatusOrder OrderStatus { get; set; }

    }
}
