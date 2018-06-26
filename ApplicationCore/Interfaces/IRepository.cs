using System;
using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
	public interface IRepository<T> where T: BaseEntity
    {
		T GetById(int id);
		T GetSingleBySpec(ISpecification<T> specification);
		IEnumerable<T> ListAll();
		IEnumerable<T> List(ISpecification<T> specification);
		T Add(T entity);
		void Update(T entity);
		void Delete(T entity);
    }
}
