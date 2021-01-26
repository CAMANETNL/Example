using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Example.Domain.Deals.Interfaces
{
    public interface IDealsService
    {
        Task<IEnumerable<Deal>> GetDealsAsync();

        Task<Deal> GetDealAsync(int id);

        Task<Deal> AddDealAsync(double buyerHourlyRate, int buyerId, int buyerContractTemplate, double sellerHourlyRate, int sellerId, int sellerContractTemplate);
    }
}
