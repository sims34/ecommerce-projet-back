using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    public class Basket
    {
        [Key]
        public int BasketId { get; set; }
        public Account Account { get; set; }
        public List<BasketItems> BasketItems { get; set; }
        
    }
}