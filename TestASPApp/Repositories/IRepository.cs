using System.Collections.Generic;

namespace TestASPApp.Repositories
{
	//The Generic Interface Repository for Performing Read/Add/Delete operations
	public interface IRepository<TEntity, in TPkey> where TEntity : class
	{
		IEnumerable<TEntity> Get();
		TEntity Get(TPkey id);
		void Add(TEntity entity);
		void Remove(TEntity entity);
		void Update(TEntity entity);
	}
}