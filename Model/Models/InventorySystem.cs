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
        public Article Article { get; set; }
        public int Quantity { get; set; }
        public DateTime DateInventory { get; set; }
    }

}
