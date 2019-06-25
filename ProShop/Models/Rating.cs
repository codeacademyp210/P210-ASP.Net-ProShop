using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProShop.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public byte Point { get; set; }

        public Product Product { get; set; }
    }
}