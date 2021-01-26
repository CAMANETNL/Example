using Example.Domain.Companies;
using Example.Domain.Contracts;
using Example.Domain.Deals;
using Microsoft.EntityFrameworkCore;

namespace Example.Infrastructure.Data
{
    public class AppDbContext : DbContext
    { 
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractTemplate> ContractTemplates { get; set; }
        public DbSet<Company> Companies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // 'AppDbContext' should declare a constructor that accepts a DbContextOptions<AppDbContext> 
            // and must pass it to the base constructor for DbContext.
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}