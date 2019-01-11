using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Inventory
    {
        public Guid InventoryId { get; set; }
        public List<Article> Articles { get; set; }
        public int CountInventory => Articles == null ? 0 : Articles.Count();
        public DateTime DateTime { get; set; }
    }
}
