using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PearlTech.Framework.Models;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace PearlTech.DAL
{
    public class DataContext : DbContext
    {
        public DataContext() : base("PTTest")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set;  }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductOrder>()
                        .HasKey(k => new { k.ProductId, k.OrderId});
        }

    }
}
