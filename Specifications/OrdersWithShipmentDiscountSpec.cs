using OrdersSpecifications.Models;
using OrdersSpecifications.SpecificationsBasis;

namespace OrdersSpecifications.Specifications
{
    public class OrdersWithShipmentDiscountSpec : ISpecification<Order>
    {
        private readonly decimal _minAmount;
        private readonly decimal _maxAmount;
        public OrdersWithShipmentDiscountSpec(decimal minAmount, decimal maxAmount)
        {
            _minAmount = minAmount;
            _maxAmount = maxAmount;
        }
        public bool IsSatisfiedBy(Order item) => (item.Amount >= _minAmount) && (item.Amount < _maxAmount);
    }
}
