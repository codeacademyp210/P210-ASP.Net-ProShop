using ProShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProShop.DAL
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("DBConn")
        {
        }

        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}