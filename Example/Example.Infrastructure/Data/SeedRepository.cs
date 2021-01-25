using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Example.Domain.Contracts;
using Example.Domain.Companies;
using Example.Domain.SharedKernel;

namespace Example.Infrastructure.Data
{
    public class SeedRepository : ISeedRepository
    {
        public readonly ContractTemplate buyContractTemplate = new ContractTemplate("Buying party [Company.Name] has agreed with Broker to pay an hourly rate of [HourlyRate] for contracter [Person.FullName]");
        public readonly ContractTemplate sellContractTemplate = new ContractTemplate("Selling party [Person.FullName] has agreed with Broker to get an hourly rate of [HourlyRate] while working for [Company.Name]");
        public readonly Company buyer = new Company("Company B");

        public readonly Company seller = new Company("Piet");
        private readonly AppDbContext _dbContext;

        public SeedRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> PopulateTestDataAsync()
        {
            await CleanDatabaseAsync();
            _dbContext.Database.EnsureCreated();
            _dbContext.Companies.Add(buyer);
            _dbContext.Companies.Add(seller);
            _dbContext.ContractTemplates.Add(buyContractTemplate);
            _dbContext.ContractTemplates.Add(sellContractTemplate);

            _dbContext.SaveChanges();

            string res = $"\"companyid\": \"{buyer.Id}\",\n\r";
            res += $"\"companyid\": \"{buyContractTemplate.Id}\"\n\r";
            res += $"\"companyid\": \"{seller.Id}\",\n\r";
            res += $"\"templateId\": \"{sellContractTemplate.Id}\"\n\r";

            return res;
        }

        private async Task CleanDatabaseAsync()
        {
            await DetachEntriesAsync();
            _dbContext.Database.EnsureDeleted();
        }

        private async Task DetachEntriesAsync()
        {
            _dbContext.Database.EnsureCreated();
            await _dbContext.Companies.ForEachAsync(c => _dbContext.Entry(c).State = EntityState.Detached);
            await _dbContext.ContractTemplates.ForEachAsync(c => _dbContext.Entry(c).State = EntityState.Detached);
            await _dbContext.SaveChangesAsync();
        }
    }
}