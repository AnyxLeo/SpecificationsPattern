using System;
using System.Collections.Generic;
using System.Text;

namespace OrdersSpecifications.Models
{
    public static class OrderItems
    {
        public static List<Order> allOrders = new List<Order>()
        {
            new Order {
                OrderID = 1,
                CustomerName = "Microsoft",
                ShippedDate =  Convert.ToDateTime("2020-03-19T19:00:00"),
                ShipperCity = "Guadalajara, JAL, Mexico",
                Amount = 300,
                IsShipped = true,
            },
            new Order {
                OrderID = 2,
                CustomerName = "Microsoft",
                ShippedDate =  Convert.ToDateTime("2020-05-08T18:00:00"),
                ShipperCity = "Guadalajara, JAL, Mexico",
                Amount = 90,
                IsShipped = false,
            },
             new Order {
                OrderID = 3,
                CustomerName = "Unosquare LLC",
                ShippedDate =  Convert.ToDateTime("2020-02-13T19:00:00"),
                ShipperCity = "Leon, GTO, Mexico",
                Amount = 500,
                IsShipped = true,
            },
            new Order {
                OrderID = 4,
                CustomerName = "Vesta",
                ShippedDate =  Convert.ToDateTime("2020-07-19T19:00:00"),
                ShipperCity = "Monterrey, NL, Mexico",
                Amount = 455,
                IsShipped = true,
            },
             new Order {
                OrderID = 5,
                CustomerName = "Super La Playa",
                ShippedDate =  Convert.ToDateTime("2020-05-22T19:00:00"),
                ShipperCity = "Guadalajara, JAL, Mexico",
                Amount = 78,
                IsShipped = true,
            },
            new Order {
                OrderID = 6,
                CustomerName = "OXXO",
                ShippedDate =  Convert.ToDateTime("2020-08-11T19:00:00"),
                ShipperCity = "Durango, DGO, Mexico",
                Amount = 300,
                IsShipped = true,
            },
             new Order {
                OrderID = 7,
                CustomerName = "Super La Playa",
                ShippedDate =  Convert.ToDateTime("2020-04-14T19:00:00"),
                ShipperCity = "Guadalajara, JAL, Mexico",
                Amount = 123,
                IsShipped = true,
            },
            new Order {
                OrderID = 8,
                CustomerName = "OXXO",
                ShippedDate =  Convert.ToDateTime("2020-07-26T19:00:00"),
                ShipperCity = "Durango, DGO, Mexico",
                Amount = 345,
                IsShipped = true,
            },
             new Order {
                OrderID = 9,
                CustomerName = "Vesta",
                ShippedDate =  Convert.ToDateTime("2020-06-22T19:00:00"),
                ShipperCity = "Monterrey, NL, Mexico",
                Amount = 221,
                IsShipped = true,
            },
            new Order {
                OrderID = 10,
                CustomerName = "Unosquare LLC",
                ShippedDate =  Convert.ToDateTime("2020-01-18T19:00:00"),
                ShipperCity = "Leon, GTO, Mexico",
                Amount = 345,
                IsShipped = true,
            },
            new Order {
                OrderID = 11,
                CustomerName = "Microsoft",
                ShippedDate =  Convert.ToDateTime("2020-07-08T18:00:00"),
                ShipperCity = "Guadalajara, JAL, Mexico",
                Amount = 900,
                IsShipped = false,
            },
        };
    }
}
