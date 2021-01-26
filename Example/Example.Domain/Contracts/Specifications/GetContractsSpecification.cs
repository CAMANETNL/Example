using Ardalis.Specification;
using Example.Domain.Contracts;

namespace POCApi.Core.Specifications
{
    public class GetContractsSpecification : Specification<Contract>
    {
        public GetContractsSpecification(int companyId)
        {
            Query
                .Where(c => c.Company.Id == companyId)
                .Include(c => c.Template);
            Query.Include(c => c.Company);
        }
    }
}