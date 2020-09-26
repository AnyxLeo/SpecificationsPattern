using OrdersSpecifications.Extensions;
using OrdersSpecifications.Models;
using OrdersSpecifications.Repositories;
using OrdersSpecifications.Specifications;
using System;
using System.Collections.Generic;

namespace OrdersSpecifications
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Specifications Pattern!");
            var repository = new OrderRepository();

            var microsoftOrders = repository.GetOrders(new OrderByCustomerNameSpec("Microsoft"));
            PrintList("Microsoft Orders", microsoftOrders);

            var ordersWithShippmentDiscount = repository.GetOrders(new OrdersWithShipmentDiscountSpec(300, 500));
            PrintList("Orders With Shipment Discount", ordersWithShippmentDiscount);

            var ordersWithFreeShippment = repository.GetOrders(new OrdersWithFreeShipmentSpec(500));
            PrintList("Orders With Free Shipment", ordersWithFreeShippment);

            var specMicrosoftOrdersWithShippmentDiscount = new OrderByCustomerNameSpec("Microsoft")
                            .And(new OrdersWithShipmentDiscountSpec(300, 500))
                            .Or(new OrdersWithFreeShipmentSpec(500));
            var microsoftOrdersWithShippmentDiscount = repository.GetOrders(specMicrosoftOrdersWithShippmentDiscount);
            PrintList("Microsoft Orders With ShippmentDiscount", microsoftOrdersWithShippmentDiscount);

            var specMicrosoftOrdersWithoutShippmentDiscount = new OrdersWithShipmentDiscountSpec(300, 500)
                            .Or(new OrdersWithFreeShipmentSpec(500))
                            .Not()
                            .And(new OrderByCustomerNameSpec("Microsoft"));
            var microsoftOrdersWithoutShippmentDiscount = repository.GetOrders(specMicrosoftOrdersWithoutShippmentDiscount);
            PrintList("Microsoft Orders Without ShippmentDiscount", microsoftOrdersWithoutShippmentDiscount);

            Console.ReadLine();
        }

        private static void PrintList(string title, IEnumerable<Order> list)
        {
            Console.WriteLine($"** {title}");
            Console.WriteLine("__________________________________________________________________________________________");
            Console.WriteLine("Order ID | Customer Name | Shipped Date | Shipper City             | Amount | Is Shipped?");

            foreach(var item in list) 
                Console.WriteLine($"{item.OrderID.ToString().PadRight(8)} | {item.CustomerName.PadRight(13)} | {item.ShippedDate.ToShortDateString().PadRight(12)} | {item.ShipperCity.PadRight(24)} | {item.Amount.ToString().PadRight(6)} | {(item.IsShipped ? "Yes" : "No")} ");
                      
            Console.WriteLine("__________________________________________________________________________________________");
            Console.WriteLine();
        }
    }
}
 