using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabCoffeeShopApp.Data
{
    public class CoffeeShopContext : DbContext
    {
        public CoffeeShopContext(DbContextOptions<CoffeeShopContext> options) : base(options)
        { }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }

    }
}
