using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models
{
    public class BasketItems
    {
        [Key]
        public Guid IdBasketItems { get; set; }
        public int UnitePrice { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Article")]
        public Guid ArticleId { get; set; }
        public virtual Article Article { get; set; }

        [ForeignKey("Basket")]
        public Guid BasketId { get; set; }
        public virtual Basket Basket { get; set; }
    }
}
