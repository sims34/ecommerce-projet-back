using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Models
{
    public class Article
    {
        [Key]
        public Guid IdArticle { get; set; }
        public String Label { get; set; }
        public String Description { get; set; }
        public int PriceHT { get; set; }
        public int Tax { get; set; }
        public bool Activate { get; set; }
        public int DelievryTime { get; set; }

    }
}
