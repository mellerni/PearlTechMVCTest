
namespace PTTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using PTTest.Models;
    using System.Collections.Generic;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PTTest.DAL.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PTTest.DAL.DataContext context)
        {
            //   This method will be called after migrating to the latest version.
         
           context.Customers.AddOrUpdate(c => new {c.CustomerID, c.FirstName, c.LastName, c.CustomerNumber },
              new Customer { CustomerID = 1, FirstName = "Carson", LastName = "Alexander", CustomerNumber = 14568},
              new Customer { CustomerID = 2, FirstName = "Meredith", LastName = "Alonso", CustomerNumber = 133460 },
              new Customer { CustomerID = 3, FirstName = "Arturo", LastName = "Anand", CustomerNumber = 133459 },
              new Customer { CustomerID = 4, FirstName = "Gytis", LastName = "Barzdukas", CustomerNumber = 133458 },
              new Customer { CustomerID = 5, FirstName = "Yan", LastName = "Li", CustomerNumber = 1334898 },
              new Customer { CustomerID = 6, FirstName = "Peggy", LastName = "Justice", CustomerNumber = 133451 },
              new Customer { CustomerID = 7, FirstName = "Laura", LastName = "Norman", CustomerNumber = 133453 },
              new Customer { CustomerID = 8, FirstName = "Nino", LastName = "Olivetto", CustomerNumber = 133455 },
              new Customer { CustomerID = 9, FirstName = "Matt", LastName = "Porter", CustomerNumber = 888888 },
              new Customer { CustomerID = 10, FirstName = "Nicole", LastName = "Brown", CustomerNumber = 888889 },
              new Customer { CustomerID = 11, FirstName = "Jen", LastName = "Luzius", CustomerNumber = 888890 }
            );
            context.SaveChanges();

            var orderDate = DateTime.Now;
            var shipDate = DateTime.Now;
            shipDate = shipDate.AddDays(30);

            context.Orders.AddOrUpdate(o => new { o.OrderID, o.OrderDT, o.ShippedDT, o.OrderNumber, o.CustomerID },
                new Order() { OrderID = 1, OrderDT = orderDate, ShippedDT = shipDate,
                    OrderNumber = 133456, CustomerID = 1 },
                new Order() { OrderID = 2, OrderDT = orderDate, ShippedDT = shipDate,
                    OrderNumber = 125543, CustomerID = 2 },
                new Order() { OrderID = 3, OrderDT = orderDate, ShippedDT = shipDate,
                    OrderNumber = 51486, CustomerID = 3 },
                new Order() { OrderID = 4, OrderDT = orderDate, ShippedDT = shipDate,
                    OrderNumber = 1234554, CustomerID = 4 },
                new Order() { OrderID = 5, OrderDT = orderDate, ShippedDT = shipDate,
                    OrderNumber = 1413086, CustomerID = 5 },
                new Order() { OrderID = 6, OrderDT = orderDate, ShippedDT = shipDate,
                    OrderNumber = 1461436, CustomerID = 6 },
                new Order() { OrderID = 7, OrderDT = orderDate, ShippedDT = shipDate,
                    OrderNumber = 1749846, CustomerID = 7 },
                new Order() { OrderID = 8, OrderDT = orderDate, ShippedDT = shipDate,
                    OrderNumber = 1346, CustomerID = 8 },
                new Order() { OrderID = 9, OrderDT = orderDate, ShippedDT = shipDate,
                    OrderNumber = 1897, CustomerID = 9 },
                new Order() { OrderID = 10, OrderDT = orderDate, ShippedDT = shipDate,
                    OrderNumber = 1336546, CustomerID = 10 },
                new Order() { OrderID = 11, OrderDT = orderDate, ShippedDT = shipDate,
                    OrderNumber = 654654, CustomerID = 11 }
                );
            context.SaveChanges();


            context.Products.AddOrUpdate(p => new { p.ProdcutID, p.ProductName },
                new Product() { ProdcutID = 1, ProductName = "Dell Computer" },
                new Product() { ProdcutID = 2, ProductName = "Acer Monitor" },
                new Product() { ProdcutID = 3, ProductName = "Alienware Laptop" }
                );
            context.SaveChanges();

            context.ProductOrder.AddOrUpdate(o => new { o.ProductID, o.OrderID, o.Quantity },
                    new ProductOrder() { ProductID = 1, OrderID = 1, Quantity = 3 },
                    new ProductOrder() { ProductID = 2, OrderID = 2, Quantity = 3 },
                    new ProductOrder() { ProductID = 3, OrderID = 3, Quantity = 3 },
                    new ProductOrder() { ProductID = 1, OrderID = 4, Quantity = 3 },
                    new ProductOrder() { ProductID = 2, OrderID = 5, Quantity = 3 },
                    new ProductOrder() { ProductID = 3, OrderID = 6, Quantity = 3 },
                    new ProductOrder() { ProductID = 1, OrderID = 7, Quantity = 3 },
                    new ProductOrder() { ProductID = 2, OrderID = 8, Quantity = 3 },
                    new ProductOrder() { ProductID = 3, OrderID = 9, Quantity = 3 },
                    new ProductOrder() { ProductID = 1, OrderID = 9, Quantity = 3 },
                    new ProductOrder() { ProductID = 2, OrderID = 10, Quantity = 3 },
                    new ProductOrder() { ProductID = 3, OrderID = 10, Quantity = 3 },
                    new ProductOrder() { ProductID = 3, OrderID = 11, Quantity = 3 },
                    new ProductOrder() { ProductID = 2, OrderID = 11, Quantity = 3 }
                );
            context.SaveChanges();

            base.Seed(context);

        }
    }
}
