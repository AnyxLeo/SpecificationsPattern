namespace OrdersSpecifications.SpecificationsBasis
{
    public abstract class Specification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfiedBy(T item);
    }
}
