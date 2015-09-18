using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PTTest.Models;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace PTTest.DAL
{
    class DataContext : DbContext
    {
        public DataContext() : base("PTTest")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, PTTest.Migrations.Configuration>("PTTest"));
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set;  }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductOrder>()
                        .HasKey(k => new { k.ProductID, k.OrderID});
        }

    }
}
