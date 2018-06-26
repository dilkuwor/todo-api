using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
	public interface IAsyncRepository<T> where T: BaseEntity
    {
		Task<T> GetByIdAsync(int id);
		Task<IEnumerable<T>> ListAllAsync();
		Task<IEnumerable<T>> ListAsync(ISpecification<T> specification);
		Task<T> AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(T entity);
    }
}
