using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class InventoryItem
    {
        public Guid InventoryItemId { get; set; }
        public Article Article { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        //public InventorySystem InventorySystem { get; set; }
        public void AddToQuantity(int AmountQuantity) => Quantity += AmountQuantity;

    }
}
