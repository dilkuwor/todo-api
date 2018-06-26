using System;
using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
	public interface IAsyncRepository<T> where T: BaseEntity
    {
		T GetByIdAsync(int id);
		IEnumerable<T> ListAllAsync();
		IEnumerable<T> ListAsync(ISpecification<T> specification);
		T AddAsync(T entity);
		void UpdateAsync(T entity);
		void DeleteAsync(T entity);
    }
}
