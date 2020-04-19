using Core.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using Core.Specifications;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
         Task<T> GetByIdAsync(int id);
         Task<IReadOnlyList<T>> ListAllAsync();
         Task<T> GetEntityWithSpec(ISpecification<T> specification);
         Task<IReadOnlyList<T>> ListAsync(ISpecification<T> specification);
    }
}