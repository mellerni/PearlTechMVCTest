using System;
using System.Data.Entity.Migrations;
using PearlTech.DAL;
using PearlTech.Framework.Models;

namespace DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataContext context)
        {
            //This method will be called after migrating to the latest version.

         context.Customers.AddOrUpdate(c => new { c.Id, c.FirstName, c.LastName, c.CustomerNumber },
            new Customer { Id = 1, FirstName = "Carson", LastName = "Alexander", CustomerNumber = 14568 },
            new Customer { Id = 2, FirstName = "Meredith", LastName = "Alonso", CustomerNumber = 133460 },
            new Customer { Id = 3, FirstName = "Arturo", LastName = "Anand", CustomerNumber = 133459 },
            new Customer { Id = 4, FirstName = "Gytis", LastName = "Barzdukas", CustomerNumber = 133458 },
            new Customer { Id = 5, FirstName = "Yan", LastName = "Li", CustomerNumber = 1334898 },
            new Customer { Id = 6, FirstName = "Peggy", LastName = "Justice", CustomerNumber = 133451 },
            new Customer { Id = 7, FirstName = "Laura", LastName = "Norman", CustomerNumber = 133453 },
            new Customer { Id = 8, FirstName = "Nino", LastName = "Olivetto", CustomerNumber = 133455 },
            new Customer { Id = 9, FirstName = "Matt", LastName = "Porter", CustomerNumber = 888888 },
            new Customer { Id = 10, FirstName = "Nicole", LastName = "Brown", CustomerNumber = 888889 },
            new Customer { Id = 11, FirstName = "Jen", LastName = "Luzius", CustomerNumber = 888890 }
          );
            context.SaveChanges();

            var orderDate = DateTime.Now;
            var shipDate = DateTime.Now;
            shipDate = shipDate.AddDays(30);

            context.Orders.AddOrUpdate(o => new { o.Id, o.OrderDT, o.ShippedDT, o.OrderNumber, o.CustomerId },
                new Order()
                {
                    Id = 1,
                    OrderDT = orderDate,
                    ShippedDT = shipDate,
                    OrderNumber = 133456,
                    CustomerId = 1
                },
                new Order()
                {
                    Id = 2,
                    OrderDT = orderDate,
                    ShippedDT = shipDate,
                    OrderNumber = 125543,
                    CustomerId = 2
                },
                new Order()
                {
                    Id = 3,
                    OrderDT = orderDate,
                    ShippedDT = shipDate,
                    OrderNumber = 51486,
                    CustomerId = 3
                },
                new Order()
                {
                    Id = 4,
                    OrderDT = orderDate,
                    ShippedDT = shipDate,
                    OrderNumber = 1234554,
                    CustomerId = 4
                },
                new Order()
                {
                    Id = 5,
                    OrderDT = orderDate,
                    ShippedDT = shipDate,
                    OrderNumber = 1413086,
                    CustomerId = 5
                },
                new Order()
                {
                    Id = 6,
                    OrderDT = orderDate,
                    ShippedDT = shipDate,
                    OrderNumber = 1461436,
                    CustomerId = 6
                },
                new Order()
                {
                    Id = 7,
                    OrderDT = orderDate,
                    ShippedDT = shipDate,
                    OrderNumber = 1749846,
                    CustomerId = 7
                },
                new Order()
                {
                    Id = 8,
                    OrderDT = orderDate,
                    ShippedDT = shipDate,
                    OrderNumber = 1346,
                    CustomerId = 8
                },
                new Order()
                {
                    Id = 9,
                    OrderDT = orderDate,
                    ShippedDT = shipDate,
                    OrderNumber = 1897,
                    CustomerId = 9
                },
                new Order()
                {
                    Id = 10,
                    OrderDT = orderDate,
                    ShippedDT = shipDate,
                    OrderNumber = 1336546,
                    CustomerId = 10
                },
                new Order()
                {
                    Id = 11,
                    OrderDT = orderDate,
                    ShippedDT = shipDate,
                    OrderNumber = 654654,
                    CustomerId = 11
                }
                );
            context.SaveChanges();


            context.Products.AddOrUpdate(p => new { p.Id, p.ProductName },
                new Product() { Id = 1, ProductName = "Dell Computer" },
                new Product() { Id = 2, ProductName = "Acer Monitor" },
                new Product() { Id = 3, ProductName = "Alienware Laptop" }
                );
            context.SaveChanges();

            context.ProductOrder.AddOrUpdate(o => new { o.ProductId, o.OrderId, o.Quantity },
                    new ProductOrder() { ProductId = 1, OrderId = 1, Quantity = 3 },
                    new ProductOrder() { ProductId = 2, OrderId = 2, Quantity = 3 },
                    new ProductOrder() { ProductId = 3, OrderId = 3, Quantity = 3 },
                    new ProductOrder() { ProductId = 1, OrderId = 4, Quantity = 3 },
                    new ProductOrder() { ProductId = 2, OrderId = 5, Quantity = 3 },
                    new ProductOrder() { ProductId = 3, OrderId = 6, Quantity = 3 },
                    new ProductOrder() { ProductId = 1, OrderId = 7, Quantity = 3 },
                    new ProductOrder() { ProductId = 2, OrderId = 8, Quantity = 3 },
                    new ProductOrder() { ProductId = 3, OrderId = 9, Quantity = 3 },
                    new ProductOrder() { ProductId = 1, OrderId = 9, Quantity = 3 },
                    new ProductOrder() { ProductId = 2, OrderId = 10, Quantity = 3 },
                    new ProductOrder() { ProductId = 3, OrderId = 10, Quantity = 3 },
                    new ProductOrder() { ProductId = 3, OrderId = 11, Quantity = 3 },
                    new ProductOrder() { ProductId = 2, OrderId = 11, Quantity = 3 }
                );
            context.SaveChanges();

            base.Seed(context);

        }
    }
}
