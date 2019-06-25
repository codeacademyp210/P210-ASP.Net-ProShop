using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Desc { get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}