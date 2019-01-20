using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class InventorySystem
    {
        [Key]
        public Guid InventorySysID { get; set; }
        public List<InventoryItem> InventoryItems { get; set; }
        public int TotalInventory => InventoryItems == null ? 0 : InventoryItems.Sum(x => x.Quantity);
    }
}
