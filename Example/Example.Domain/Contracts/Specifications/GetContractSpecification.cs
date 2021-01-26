using Ardalis.Specification;

namespace Example.Domain.Contracts.Specifications
{
    public class GetContractSpecification : Specification<Contract>
    {
        public GetContractSpecification(int companyId, int contractId)
        {
            Query
                .Where(c => c.Id == contractId)
                .Where(c => c.Company.Id == companyId)
                 .Include(c => c.Template);
            Query.Include(c => c.Company);
        }
    }
}