using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Model.Models
{
    public class Basket
    {
        [Key]
        public Guid BasketId { get; set; }
        public Guid AccountId { get; set; }
        public Account Account { get; set; }
        public List<BasketItems> BasketItems { get; set; }

        public int TotalItems => BasketItems == null ? 0 : BasketItems.Sum(x => x.Quantity);
    }
}