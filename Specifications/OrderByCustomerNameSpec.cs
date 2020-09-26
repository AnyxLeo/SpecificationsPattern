using OrdersSpecifications.Models;
using OrdersSpecifications.SpecificationsBasis;

namespace OrdersSpecifications.Specifications
{
    public class OrderByCustomerNameSpec : ISpecification<Order>
    {
        private string _customerName;
        public OrderByCustomerNameSpec(string customerName) => _customerName = customerName;
        public bool IsSatisfiedBy(Order item) => item.CustomerName == _customerName;
    }
}
