using OrdersSpecifications.Models;
using OrdersSpecifications.SpecificationsBasis;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdersSpecifications.Repositories
{
    public class OrderRepository
    {
        public IEnumerable<Order> GetOrders(ISpecification<Order> specification)
        {
            return GetResult(specification, OrderItems.allOrders);
        }

        private IEnumerable<Order> GetResult(ISpecification<Order> specification, List<Order> orders)
        {
            var result = new List<Order>();
            foreach (var order in orders)
                if (specification.IsSatisfiedBy(order))
                    result.Add(order);

            return result;
        }
    }
}
