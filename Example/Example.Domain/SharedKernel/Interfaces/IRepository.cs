using Ardalis.Specification;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.Domain.SharedKernel.Interfaces
{
    public interface IRepository<T> where T : Entity

    {
        Task<T> GetByIdAsync(int id);

        Task<T> GetAsync(ISpecification<T> spec);

        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);

        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);
    }
}
