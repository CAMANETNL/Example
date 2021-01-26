using Ardalis.Specification;

namespace Example.Domain.Contracts.Specifications
{
    public class GetContractSpecification : Specification<Contract>
    {
        public GetContractSpecification(int contractId)
        {
            Query
                .Where(c => c.Id == contractId)
                 .Include(c => c.Template);
            Query.Include(c => c.Company);
        }
    }
}