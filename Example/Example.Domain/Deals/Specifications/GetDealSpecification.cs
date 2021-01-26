using Ardalis.Specification;

namespace Example.Domain.Deals.Specifications
{
    public class GetDealSpecification : Specification<Deal>
    {
        public GetDealSpecification(int id)
        {
            Query.Where(d => d.Id == id);
            Query.Include(x => x.Sell).ThenInclude(c => c.Company);
            Query.Include(x => x.Sell).ThenInclude(c => c.Template);
            Query.Include(x => x.Buy).ThenInclude(c => c.Company);
            Query.Include(x => x.Buy).ThenInclude(c => c.Template);
        }
    }
}