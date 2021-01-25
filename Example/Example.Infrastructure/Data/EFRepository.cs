using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Example.Domain.SharedKernel;
using Example.Domain.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Example.Infrastructure.Data
{
    public class EFRepository<T> : IRepository<T> where T : Entity
    {
        private readonly AppDbContext _dbContext;

        public EFRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<T> GetAsync(ISpecification<T> spec)
        {
            var specificationResult = ApplySpecification(spec);
            return await specificationResult.SingleAsync();
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            var specificationResult = ApplySpecification(spec);
            return await specificationResult.ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            var evaluator = new SpecificationEvaluator<T>();
            return evaluator.GetQuery(_dbContext.Set<T>().AsQueryable(), spec);
        }
    }
}