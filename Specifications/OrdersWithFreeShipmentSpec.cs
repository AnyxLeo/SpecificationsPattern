using OrdersSpecifications.Models;
using OrdersSpecifications.SpecificationsBasis;
using System.Runtime.CompilerServices;

namespace OrdersSpecifications.Specifications
{
    public class OrdersWithFreeShipmentSpec : ISpecification<Order>
    {
        private readonly decimal _minAmount;
        public OrdersWithFreeShipmentSpec(decimal minAmount)
        {
            _minAmount = minAmount;
        }
        public bool IsSatisfiedBy(Order item) => item.Amount >= _minAmount;
    }
}
