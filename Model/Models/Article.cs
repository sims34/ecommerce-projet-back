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
        public string Label { get; set; }
        public string Description { get; set; }
        public int PriceHT { get; set; }
        public int Tax { get; set; }
        public bool Activate { get; set; }
        public int DelievryTime { get; set; }
     //   public String ImgUrl { get; set; }

    }
}
