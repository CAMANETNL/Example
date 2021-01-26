using Ardalis.GuardClauses;
using Example.Domain.Companies;
using Example.Domain.Contracts;
using Example.Domain.Deals;
using Example.Domain.Deals.Interfaces;
using Example.Domain.Deals.Specifications;
using Example.Domain.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.Application.Deals
{
    public class DealsService : IDealsService
    {
        private readonly IRepository<Deal> _dealsRepo;
        private readonly IRepository<Company> _companiesRepo;
        private readonly IRepository<ContractTemplate> _templatesRepo;

        public DealsService(
            IRepository<Deal> dealsRepo,
            IRepository<Company> companiesRepo,
            IRepository<ContractTemplate> templatesRepo
            )
        {
            _dealsRepo = dealsRepo;
            _companiesRepo = companiesRepo;
            _templatesRepo = templatesRepo;
        }

        public async Task<IEnumerable<Deal>> GetDealsAsync()
        {
            return await _dealsRepo.ListAsync(new GetDealsSpecification());
        }

        public async Task<Deal> GetDealAsync(int id)
        {
            var res = await _dealsRepo.GetAsync(new GetDealSpecification(id));
            Guard.Against.Null(res, nameof(Deal));
            return res;
        }

        public async Task<Deal> AddDealAsync(double buyerHourlyRate, int buyerId, int buyerContractTemplateId, double sellerHourlyRate, int sellerId, int sellerContractTemplateId)
        {
            var buyer = await _companiesRepo.GetByIdAsync(buyerId);
            Guard.Against.Null(buyer, nameof(buyer));

            var buyerContractTemplate = await _templatesRepo.GetByIdAsync(buyerContractTemplateId);
            Guard.Against.Null(buyerContractTemplate, nameof(buyerContractTemplate));

            var seller = await _companiesRepo.GetByIdAsync(sellerId);
            Guard.Against.Null(seller, nameof(seller));

            var sellerContractTemplate = await _templatesRepo.GetByIdAsync(sellerContractTemplateId);
            Guard.Against.Null(sellerContractTemplate, nameof(sellerContractTemplate));

            var buyerContract = new Contract(buyerHourlyRate, buyer, buyerContractTemplate);
            var sellerContract = new Contract(sellerHourlyRate, seller, sellerContractTemplate);

            var deal = new Deal(buyerContract, sellerContract);
            return await _dealsRepo.AddAsync(deal);
        }
    }
}