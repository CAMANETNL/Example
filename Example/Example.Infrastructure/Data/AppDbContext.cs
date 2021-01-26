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

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // TODO: Remove hardcoded string
            options.UseSqlite(
                @"Data Source=C:\Users\Meloen\Documents\Example\Example.Infrastructure\sqlite.db", 
                b => b.MigrationsAssembly("Example.API"));
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