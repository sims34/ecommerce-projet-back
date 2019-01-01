using System.Collections.Generic;

namespace Model.Models
{
    public class Basket
    {
        public int BasketId { get; set; }
        public Account Account { get; set; }
        public ICollection<BasketItems> BasketItems { get; set; }
        
    }
}