using Ardalis.Specification;
using Example.Domain.Contracts;

namespace POCApi.Core.Specifications
{
    public class GetContractsSpecification : Specification<Contract>
    {
        public GetContractsSpecification()
        {
            Query
                .Include(c => c.Template);
            Query.Include(c => c.Company);
        }
    }
}