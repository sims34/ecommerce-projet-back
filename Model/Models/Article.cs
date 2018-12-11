using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Article
    {
        public Guid Id { get; set; }
        public String Label { get; set; }
        public String Description { get; set; }
        public int PriceHT { get; set; }
        public int Taxs { get; set; }
        public Boolean Activate { get; set; }
    }
}
