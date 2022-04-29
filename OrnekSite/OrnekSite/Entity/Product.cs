using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrnekSite.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public  string  Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool Slider { get; set; }
        public bool IsHome { get; set; } //Anasayfa
        public bool IsFeatured { get; set; } //Öne çıkan
        public bool IsApproved { get; set; } //Onaylı mı değilse yalnızca admin paneli görür
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}