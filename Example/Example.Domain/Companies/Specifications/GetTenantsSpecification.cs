using Ardalis.Specification;

namespace Example.Domain.Companies.Specifications
{
    public class GetTenantsSpecification : Specification<Company>
    {
        public GetTenantsSpecification()
        {
            Query
                .OrderByDescending(t => t.Name.ToLower());
        }
    }
}