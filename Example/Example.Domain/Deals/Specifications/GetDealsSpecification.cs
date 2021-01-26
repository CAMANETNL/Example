using Ardalis.Specification;

namespace Example.Domain.Deals.Specifications
{
    public class GetDealsSpecification : Specification<Deal>
    {
        public GetDealsSpecification()
        {
            Query.Include(x => x.Sell).ThenInclude(c => c.Company);
            Query.Include(x => x.Sell).ThenInclude(c => c.Template);
            Query.Include(x => x.Buy).ThenInclude(c => c.Company);
            Query.Include(x => x.Buy).ThenInclude(c => c.Template);
        }
    }
}