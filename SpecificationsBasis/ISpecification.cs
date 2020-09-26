namespace OrdersSpecifications.SpecificationsBasis
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T item);
    }
}
