using System;

namespace Model.Models
{
    public enum StatusOrder
    {
        New,
        Hold,
        Shipped,
        Delivered,
        Closed
    }
    public class Order
    {
        public Guid IdOrder { get; set; }
        public Account Account { get; set; }
        public Basket Basket { get; set; }
        public StatusOrder OrderStatus { get; set; }

    }
}
