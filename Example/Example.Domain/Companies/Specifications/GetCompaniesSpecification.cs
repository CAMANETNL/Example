using Ardalis.Specification;

namespace Example.Domain.Companies.Specifications
{
    public class GetCompaniesSpecification : Specification<Company>
    {
        public GetCompaniesSpecification()
        {
            Query
                .OrderByDescending(t => t.Name.ToLower());
        }
    }
}