using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Models
{
    public class BasketItems
    {
        [Key]
        public int IdBasketItems { get; set; }
        public int UnitePrice { get; set; }
        public int Quantity { get; set; }
        public Article Article { get; set; }
        public Basket Basket { get; set; }
    }
}
